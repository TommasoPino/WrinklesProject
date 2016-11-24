using System;
using System.Threading;
// remeber to add the System.Managment.dll
using System.Management;
using System.Windows.Forms;
using SensorControl;
using StepperControl;
using Phidgets;

namespace Calibration_v0_2
{
    public partial class Form1 : Form
    {
        #region Fields
        // we have a movimentation only on two axis (4 limits)
        const int numOfSensor = 4;
        LimitSwitchSensorControl limitSwitchSensorControl;
        StepperMotorControl stepperMotorControl;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            limitSwitchSensorControl = new LimitSwitchSensorControl(numOfSensor);
            limitSwitchSensorControl.Text += new SensorControl.SensorControl.TextEventHandler(AppendTextToRichTextStatusMessages);
            limitSwitchSensorControl.ArduinoConnected += new SensorControl.SensorControl.ArduinoConnectedHandler(ChangeTextBoxStatus);

            stepperMotorControl = new StepperMotorControl();
            stepperMotorControl.Text += new StepperMotorControl.TextEventHandler(AppendTextToRichTextStatusMessages);
            stepperMotorControl.ResetButtonsCalibration += new StepperMotorControl.ResetButtonsCalibrationHandler(ResetButtonsCalibration);
            stepperMotorControl.StepperConnected += new StepperMotorControl.StepperHandler(ChangeTextBoxStatus);
            stepperMotorControl.CalibrationStatus += new StepperMotorControl.StepperHandler(ChangeTextBoxStatus);

            AutodetectArduino();
        }
        #endregion

        #region ButtonClick Methods
        /// <summary>
        /// This method respond to the Calibration button in the 
        /// Calibration Tab. If the Serial port is not initialized
        /// we try to connect the arduino and start the control of
        /// the serial port
        /// If the comboBoxCOMPort is not selected a window appears
        /// If the Serial Port is already initialized only start the
        /// monitoring control 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalibration_Click(object sender, EventArgs e)
        {

            if (!limitSwitchSensorControl.SerialPortInitialized)
            {
                try
                {
                    limitSwitchSensorControl.ArduinoConnection(comboBoxCOMPort.Items[comboBoxCOMPort.SelectedIndex].ToString());
                    limitSwitchSensorControl.StartControl();
                    stepperMotorControl.InizializationMotors();
                    stepperMotorControl.StartCalibration();
                    ResetButtonsCalibration();

                }
                catch
                {
                    var confirmResult = MessageBox.Show("No COM Port is selected");
                    ResetButtonsCalibration();
                }
            }
            else
            {
                limitSwitchSensorControl.StartControl();
                if (!stepperMotorControl.InizializationMotorsStatus)
                {
                    stepperMotorControl.InizializationMotors();
                }
                stepperMotorControl.StartCalibration();
                ResetButtonsCalibration();
            }
        }

        /// <summary>
        /// This method responds to the AbortCalibration Button in the 
        /// CalibrationTab. This call the StopControl method to interupt
        /// the monitoring of serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbortCalibration_Button_Click(object sender, EventArgs e)
        {
            ResetButtonsCalibration();
            stepperMotorControl.AbortCalibration();
            limitSwitchSensorControl.StopControl();
        }

        public void ResetButtonsCalibration()
        {
            Invoke(new MethodInvoker(() =>
            {
                buttonAbortCalibration.Visible = !buttonAbortCalibration.Visible;
                buttonCalibration.Enabled = !buttonCalibration.Enabled;
            }
            )); 
        }

        /// <summary>
        /// This method tries to connect the arduino from the 
        /// InfoTab/ArduinoTab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArduinoInfoConnect_Click(object sender, EventArgs e)
        {
            bool status = limitSwitchSensorControl.ArduinoConnection(textBoxArduinoInfoCOMport.Text);
            textBoxArduinoInfoConnected.Text = status.ToString();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// This method permits to add test to the RichTextBox in the 
        /// CalibrationTab from different Thread
        /// </summary>
        /// <param name="text"></param>
        public void AppendTextToRichTextStatusMessages(string text)
        {
            richTextBoxStatusMessages.Invoke(new MethodInvoker(() =>
            {
                richTextBoxStatusMessages.AppendText(text);
                richTextBoxStatusMessages.AppendText("\n");
            }));
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method start at the beginnig when the window is initialized 
        /// to find out immidiatly the Arduino's COM port
        /// </summary>
        private void AutodetectArduino()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        textBoxArduinoInfoCOMport.Text = deviceId;
                        comboBoxCOMPort.SelectedItem = deviceId;
                        textBoxArduinoInfoConnected.Text = limitSwitchSensorControl.SerialPortInitialized.ToString();
                    }
                }
            }
            catch { }
            #endregion
        }


        /// <summary>
        /// This method change the text box status 
        /// </summary>
        /// <param name="objname"></param>
        /// <param name="status"></param>
        private void ChangeTextBoxStatus(string objname, bool status)
        {
            this.ChangeTextBoxStatus(objname, status, null);
        }
        /// <summary>
        /// This method change the text box status
        /// </summary>
        /// <param name="objname"></param>
        /// <param name="status"></param>
        /// <param name="stepper"></param>
        private void ChangeTextBoxStatus(string objname, bool status, Stepper stepper)
        {
            switch(objname)
            {
                case "Arduino":
                    Invoke(new MethodInvoker(() =>
                    {
                        textBoxArduinoInfoConnected.Text= status.ToString();
                    }
                    ));
                    break;
                case "Calibration":
                    Invoke(new MethodInvoker(() =>
                    {
                        textBoxSystemCalibrated.Text = status.ToString();
                    }
                    ));
                    break;
                case "XMotor":
                    Invoke(new MethodInvoker(() =>
                    {
                        textBoxMotorXAttached.Text = stepper.Attached.ToString();
                        textBoxMotorXName.Text = stepper.Name.ToString();
                        textBoxMotorXSerialNo.Text = stepper.SerialNumber.ToString();
                        textBoxMotorXVersion.Text = stepper.Version.ToString();
                    }
                    ));
                    break;
                case "YMotor1":
                    Invoke(new MethodInvoker(() =>
                    {
                        textBoxMotorY1Attached.Text = stepper.Attached.ToString();
                        textBoxMotorY1Name.Text = stepper.Name.ToString();
                        textBoxMotorY1SerialNo.Text = stepper.SerialNumber.ToString();
                        textBoxMotorY1Version.Text = stepper.Version.ToString();
                    }
                    ));
                    break;
                case "YMotor2":
                    Invoke(new MethodInvoker(() =>
                    {
                        textBoxMotorY2Attached.Text = stepper.Attached.ToString();
                        textBoxMotorY2Name.Text = stepper.Name.ToString();
                        textBoxMotorY2SerialNo.Text = stepper.SerialNumber.ToString();
                        textBoxMotorY2Version.Text = stepper.Version.ToString();
                    }
                    ));
                    break;
                default:
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //stepperMotorControl.StopAllMotors();
            stepperMotorControl.AbortCalibration();
            limitSwitchSensorControl.StopControl();
        }
    }
}
