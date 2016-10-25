using System;
// remeber to add the System.Managment.dll
using System.Management;
using System.Windows.Forms;
using SensorControl;

namespace Calibration_v0._2
{
    public partial class Form1 : Form
    {
        #region Fields
        // we have a movimentation only on two axis (4 limits)
        const int numOfSensor = 4;
        LimitSwitchSensorControl limitSwitchSensorControl;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            limitSwitchSensorControl = new LimitSwitchSensorControl(numOfSensor);
            limitSwitchSensorControl.Text += new SensorControl.SensorControl.TextEventHandler(AppendTextToRichTextStatusMessages);
            AutodetectArduino();
        }
        #endregion

        #region BottonClick Methods
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
                    buttonAbortCalibration.Visible = true;
                }
                catch
                {
                    var confirmResult = MessageBox.Show("No COM Port is selected");
                }
            }
            else
            {
                limitSwitchSensorControl.StartControl();
                buttonAbortCalibration.Visible = true;
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
            buttonAbortCalibration.Visible = false;
            limitSwitchSensorControl.StopControl();
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
    }
}
