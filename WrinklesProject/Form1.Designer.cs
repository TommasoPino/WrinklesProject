namespace Calibration_v0._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCalibration = new System.Windows.Forms.TabPage();
            this.labelStatusMessages = new System.Windows.Forms.Label();
            this.richTextBoxStatusMessages = new System.Windows.Forms.RichTextBox();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.labelArduinoCOMPort = new System.Windows.Forms.Label();
            this.buttonAbortCalibration = new System.Windows.Forms.Button();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.textBoxSystemCalibrated = new System.Windows.Forms.TextBox();
            this.labelSystemCalibrated = new System.Windows.Forms.Label();
            this.tabAcquisition = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageArduino = new System.Windows.Forms.TabPage();
            this.buttonArduinoInfoConnect = new System.Windows.Forms.Button();
            this.textBoxArduinoInfoCOMport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArduinoInfoConnected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePhidgetMotors = new System.Windows.Forms.TabPage();
            this.tabPageBridge = new System.Windows.Forms.TabPage();
            this.panelMotorX = new System.Windows.Forms.Panel();
            this.panelMotorsY = new System.Windows.Forms.Panel();
            this.labelMotorX = new System.Windows.Forms.Label();
            this.labelMotorsY = new System.Windows.Forms.Label();
            this.textBoxMotorXNSteppers = new System.Windows.Forms.TextBox();
            this.labelMotorXNSteppers = new System.Windows.Forms.Label();
            this.textBoxMotorXVersion = new System.Windows.Forms.TextBox();
            this.labelMotorXVersion = new System.Windows.Forms.Label();
            this.textBoxMotorXSerialNo = new System.Windows.Forms.TextBox();
            this.labelMotorXSerialNo = new System.Windows.Forms.Label();
            this.textBoxMotorXName = new System.Windows.Forms.TextBox();
            this.labelMotorXName = new System.Windows.Forms.Label();
            this.textBoxMotorXAttached = new System.Windows.Forms.TextBox();
            this.labelMotorXAttached = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabCalibration.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPageArduino.SuspendLayout();
            this.tabPagePhidgetMotors.SuspendLayout();
            this.panelMotorX.SuspendLayout();
            this.panelMotorsY.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCalibration);
            this.tabControlMain.Controls.Add(this.tabAcquisition);
            this.tabControlMain.Controls.Add(this.tabInfo);
            this.tabControlMain.Location = new System.Drawing.Point(13, 13);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(447, 349);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCalibration
            // 
            this.tabCalibration.Controls.Add(this.labelStatusMessages);
            this.tabCalibration.Controls.Add(this.richTextBoxStatusMessages);
            this.tabCalibration.Controls.Add(this.comboBoxCOMPort);
            this.tabCalibration.Controls.Add(this.labelArduinoCOMPort);
            this.tabCalibration.Controls.Add(this.buttonAbortCalibration);
            this.tabCalibration.Controls.Add(this.buttonCalibration);
            this.tabCalibration.Controls.Add(this.textBoxSystemCalibrated);
            this.tabCalibration.Controls.Add(this.labelSystemCalibrated);
            this.tabCalibration.Location = new System.Drawing.Point(4, 22);
            this.tabCalibration.Name = "tabCalibration";
            this.tabCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalibration.Size = new System.Drawing.Size(439, 323);
            this.tabCalibration.TabIndex = 0;
            this.tabCalibration.Text = "Calibration";
            this.tabCalibration.UseVisualStyleBackColor = true;
            // 
            // labelStatusMessages
            // 
            this.labelStatusMessages.AutoSize = true;
            this.labelStatusMessages.Location = new System.Drawing.Point(204, 7);
            this.labelStatusMessages.Name = "labelStatusMessages";
            this.labelStatusMessages.Size = new System.Drawing.Size(91, 13);
            this.labelStatusMessages.TabIndex = 11;
            this.labelStatusMessages.Text = "Status Messages:";
            // 
            // richTextBoxStatusMessages
            // 
            this.richTextBoxStatusMessages.Location = new System.Drawing.Point(207, 23);
            this.richTextBoxStatusMessages.Name = "richTextBoxStatusMessages";
            this.richTextBoxStatusMessages.Size = new System.Drawing.Size(226, 141);
            this.richTextBoxStatusMessages.TabIndex = 10;
            this.richTextBoxStatusMessages.Text = "";
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxCOMPort.Location = new System.Drawing.Point(105, 31);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(93, 21);
            this.comboBoxCOMPort.TabIndex = 9;
            // 
            // labelArduinoCOMPort
            // 
            this.labelArduinoCOMPort.AutoSize = true;
            this.labelArduinoCOMPort.Location = new System.Drawing.Point(7, 34);
            this.labelArduinoCOMPort.Name = "labelArduinoCOMPort";
            this.labelArduinoCOMPort.Size = new System.Drawing.Size(92, 13);
            this.labelArduinoCOMPort.TabIndex = 4;
            this.labelArduinoCOMPort.Text = "Arduino COM Port";
            // 
            // buttonAbortCalibration
            // 
            this.buttonAbortCalibration.Location = new System.Drawing.Point(6, 181);
            this.buttonAbortCalibration.Name = "buttonAbortCalibration";
            this.buttonAbortCalibration.Size = new System.Drawing.Size(68, 23);
            this.buttonAbortCalibration.TabIndex = 3;
            this.buttonAbortCalibration.Text = "Abort";
            this.buttonAbortCalibration.UseVisualStyleBackColor = true;
            this.buttonAbortCalibration.Visible = false;
            this.buttonAbortCalibration.Click += new System.EventHandler(this.buttonAbortCalibration_Button_Click);
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.Location = new System.Drawing.Point(365, 181);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(68, 23);
            this.buttonCalibration.TabIndex = 2;
            this.buttonCalibration.Text = "Calibration";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // textBoxSystemCalibrated
            // 
            this.textBoxSystemCalibrated.Location = new System.Drawing.Point(105, 4);
            this.textBoxSystemCalibrated.Name = "textBoxSystemCalibrated";
            this.textBoxSystemCalibrated.ReadOnly = true;
            this.textBoxSystemCalibrated.Size = new System.Drawing.Size(93, 20);
            this.textBoxSystemCalibrated.TabIndex = 1;
            // 
            // labelSystemCalibrated
            // 
            this.labelSystemCalibrated.AutoSize = true;
            this.labelSystemCalibrated.Location = new System.Drawing.Point(7, 7);
            this.labelSystemCalibrated.Name = "labelSystemCalibrated";
            this.labelSystemCalibrated.Size = new System.Drawing.Size(91, 13);
            this.labelSystemCalibrated.TabIndex = 0;
            this.labelSystemCalibrated.Text = "System Calibrated";
            // 
            // tabAcquisition
            // 
            this.tabAcquisition.Location = new System.Drawing.Point(4, 22);
            this.tabAcquisition.Name = "tabAcquisition";
            this.tabAcquisition.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcquisition.Size = new System.Drawing.Size(439, 323);
            this.tabAcquisition.TabIndex = 1;
            this.tabAcquisition.Text = "Acquisition";
            this.tabAcquisition.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabControlInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(439, 323);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageArduino);
            this.tabControlInfo.Controls.Add(this.tabPagePhidgetMotors);
            this.tabControlInfo.Controls.Add(this.tabPageBridge);
            this.tabControlInfo.Location = new System.Drawing.Point(7, 7);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(426, 310);
            this.tabControlInfo.TabIndex = 0;
            // 
            // tabPageArduino
            // 
            this.tabPageArduino.Controls.Add(this.buttonArduinoInfoConnect);
            this.tabPageArduino.Controls.Add(this.textBoxArduinoInfoCOMport);
            this.tabPageArduino.Controls.Add(this.label2);
            this.tabPageArduino.Controls.Add(this.textBoxArduinoInfoConnected);
            this.tabPageArduino.Controls.Add(this.label1);
            this.tabPageArduino.Location = new System.Drawing.Point(4, 22);
            this.tabPageArduino.Name = "tabPageArduino";
            this.tabPageArduino.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArduino.Size = new System.Drawing.Size(418, 284);
            this.tabPageArduino.TabIndex = 0;
            this.tabPageArduino.Text = "Arduino";
            this.tabPageArduino.UseVisualStyleBackColor = true;
            // 
            // buttonArduinoInfoConnect
            // 
            this.buttonArduinoInfoConnect.Location = new System.Drawing.Point(189, 4);
            this.buttonArduinoInfoConnect.Name = "buttonArduinoInfoConnect";
            this.buttonArduinoInfoConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonArduinoInfoConnect.TabIndex = 4;
            this.buttonArduinoInfoConnect.Text = "Connect";
            this.buttonArduinoInfoConnect.UseVisualStyleBackColor = true;
            this.buttonArduinoInfoConnect.Click += new System.EventHandler(this.buttonArduinoInfoConnect_Click);
            // 
            // textBoxArduinoInfoCOMport
            // 
            this.textBoxArduinoInfoCOMport.Location = new System.Drawing.Point(82, 29);
            this.textBoxArduinoInfoCOMport.Name = "textBoxArduinoInfoCOMport";
            this.textBoxArduinoInfoCOMport.ReadOnly = true;
            this.textBoxArduinoInfoCOMport.Size = new System.Drawing.Size(100, 20);
            this.textBoxArduinoInfoCOMport.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM port:";
            // 
            // textBoxArduinoInfoConnected
            // 
            this.textBoxArduinoInfoConnected.Location = new System.Drawing.Point(82, 3);
            this.textBoxArduinoInfoConnected.Name = "textBoxArduinoInfoConnected";
            this.textBoxArduinoInfoConnected.ReadOnly = true;
            this.textBoxArduinoInfoConnected.Size = new System.Drawing.Size(100, 20);
            this.textBoxArduinoInfoConnected.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected:";
            // 
            // tabPagePhidgetMotors
            // 
            this.tabPagePhidgetMotors.Controls.Add(this.panelMotorsY);
            this.tabPagePhidgetMotors.Controls.Add(this.panelMotorX);
            this.tabPagePhidgetMotors.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhidgetMotors.Name = "tabPagePhidgetMotors";
            this.tabPagePhidgetMotors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhidgetMotors.Size = new System.Drawing.Size(418, 284);
            this.tabPagePhidgetMotors.TabIndex = 1;
            this.tabPagePhidgetMotors.Text = "Phidget Motors";
            this.tabPagePhidgetMotors.UseVisualStyleBackColor = true;
            // 
            // tabPageBridge
            // 
            this.tabPageBridge.Location = new System.Drawing.Point(4, 22);
            this.tabPageBridge.Name = "tabPageBridge";
            this.tabPageBridge.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBridge.Size = new System.Drawing.Size(418, 284);
            this.tabPageBridge.TabIndex = 2;
            this.tabPageBridge.Text = "Bridge";
            this.tabPageBridge.UseVisualStyleBackColor = true;
            // 
            // panelMotorX
            // 
            this.panelMotorX.Controls.Add(this.textBoxMotorXNSteppers);
            this.panelMotorX.Controls.Add(this.labelMotorXNSteppers);
            this.panelMotorX.Controls.Add(this.textBoxMotorXVersion);
            this.panelMotorX.Controls.Add(this.labelMotorXVersion);
            this.panelMotorX.Controls.Add(this.textBoxMotorXSerialNo);
            this.panelMotorX.Controls.Add(this.labelMotorXSerialNo);
            this.panelMotorX.Controls.Add(this.textBoxMotorXName);
            this.panelMotorX.Controls.Add(this.labelMotorXName);
            this.panelMotorX.Controls.Add(this.textBoxMotorXAttached);
            this.panelMotorX.Controls.Add(this.labelMotorXAttached);
            this.panelMotorX.Controls.Add(this.labelMotorX);
            this.panelMotorX.Location = new System.Drawing.Point(6, 4);
            this.panelMotorX.Name = "panelMotorX";
            this.panelMotorX.Size = new System.Drawing.Size(200, 144);
            this.panelMotorX.TabIndex = 0;
            // 
            // panelMotorsY
            // 
            this.panelMotorsY.Controls.Add(this.textBox6);
            this.panelMotorsY.Controls.Add(this.label8);
            this.panelMotorsY.Controls.Add(this.textBox7);
            this.panelMotorsY.Controls.Add(this.textBox8);
            this.panelMotorsY.Controls.Add(this.label9);
            this.panelMotorsY.Controls.Add(this.label10);
            this.panelMotorsY.Controls.Add(this.label11);
            this.panelMotorsY.Controls.Add(this.textBox9);
            this.panelMotorsY.Controls.Add(this.textBox10);
            this.panelMotorsY.Controls.Add(this.label12);
            this.panelMotorsY.Controls.Add(this.textBox1);
            this.panelMotorsY.Controls.Add(this.labelMotorsY);
            this.panelMotorsY.Controls.Add(this.label3);
            this.panelMotorsY.Controls.Add(this.textBox5);
            this.panelMotorsY.Controls.Add(this.textBox2);
            this.panelMotorsY.Controls.Add(this.label7);
            this.panelMotorsY.Controls.Add(this.label4);
            this.panelMotorsY.Controls.Add(this.label6);
            this.panelMotorsY.Controls.Add(this.textBox3);
            this.panelMotorsY.Controls.Add(this.textBox4);
            this.panelMotorsY.Controls.Add(this.label5);
            this.panelMotorsY.Location = new System.Drawing.Point(212, 4);
            this.panelMotorsY.Name = "panelMotorsY";
            this.panelMotorsY.Size = new System.Drawing.Size(200, 271);
            this.panelMotorsY.TabIndex = 1;
            // 
            // labelMotorX
            // 
            this.labelMotorX.AutoSize = true;
            this.labelMotorX.Location = new System.Drawing.Point(4, 4);
            this.labelMotorX.Name = "labelMotorX";
            this.labelMotorX.Size = new System.Drawing.Size(41, 13);
            this.labelMotorX.TabIndex = 0;
            this.labelMotorX.Text = "MotorX";
            // 
            // labelMotorsY
            // 
            this.labelMotorsY.AutoSize = true;
            this.labelMotorsY.Location = new System.Drawing.Point(3, 4);
            this.labelMotorsY.Name = "labelMotorsY";
            this.labelMotorsY.Size = new System.Drawing.Size(46, 13);
            this.labelMotorsY.TabIndex = 1;
            this.labelMotorsY.Text = "MotorsY";
            // 
            // textBoxMotorXNSteppers
            // 
            this.textBoxMotorXNSteppers.Location = new System.Drawing.Point(66, 112);
            this.textBoxMotorXNSteppers.Name = "textBoxMotorXNSteppers";
            this.textBoxMotorXNSteppers.ReadOnly = true;
            this.textBoxMotorXNSteppers.Size = new System.Drawing.Size(131, 20);
            this.textBoxMotorXNSteppers.TabIndex = 19;
            // 
            // labelMotorXNSteppers
            // 
            this.labelMotorXNSteppers.AutoSize = true;
            this.labelMotorXNSteppers.Location = new System.Drawing.Point(6, 115);
            this.labelMotorXNSteppers.Name = "labelMotorXNSteppers";
            this.labelMotorXNSteppers.Size = new System.Drawing.Size(59, 13);
            this.labelMotorXNSteppers.TabIndex = 18;
            this.labelMotorXNSteppers.Text = "# Steppers";
            // 
            // textBoxMotorXVersion
            // 
            this.textBoxMotorXVersion.Location = new System.Drawing.Point(66, 89);
            this.textBoxMotorXVersion.Name = "textBoxMotorXVersion";
            this.textBoxMotorXVersion.ReadOnly = true;
            this.textBoxMotorXVersion.Size = new System.Drawing.Size(131, 20);
            this.textBoxMotorXVersion.TabIndex = 17;
            // 
            // labelMotorXVersion
            // 
            this.labelMotorXVersion.AutoSize = true;
            this.labelMotorXVersion.Location = new System.Drawing.Point(6, 92);
            this.labelMotorXVersion.Name = "labelMotorXVersion";
            this.labelMotorXVersion.Size = new System.Drawing.Size(45, 13);
            this.labelMotorXVersion.TabIndex = 16;
            this.labelMotorXVersion.Text = "Version:";
            // 
            // textBoxMotorXSerialNo
            // 
            this.textBoxMotorXSerialNo.Location = new System.Drawing.Point(66, 66);
            this.textBoxMotorXSerialNo.Name = "textBoxMotorXSerialNo";
            this.textBoxMotorXSerialNo.ReadOnly = true;
            this.textBoxMotorXSerialNo.Size = new System.Drawing.Size(131, 20);
            this.textBoxMotorXSerialNo.TabIndex = 15;
            // 
            // labelMotorXSerialNo
            // 
            this.labelMotorXSerialNo.AutoSize = true;
            this.labelMotorXSerialNo.Location = new System.Drawing.Point(6, 69);
            this.labelMotorXSerialNo.Name = "labelMotorXSerialNo";
            this.labelMotorXSerialNo.Size = new System.Drawing.Size(56, 13);
            this.labelMotorXSerialNo.TabIndex = 14;
            this.labelMotorXSerialNo.Text = "Serial No.:";
            // 
            // textBoxMotorXName
            // 
            this.textBoxMotorXName.Location = new System.Drawing.Point(66, 43);
            this.textBoxMotorXName.Name = "textBoxMotorXName";
            this.textBoxMotorXName.ReadOnly = true;
            this.textBoxMotorXName.Size = new System.Drawing.Size(131, 20);
            this.textBoxMotorXName.TabIndex = 13;
            // 
            // labelMotorXName
            // 
            this.labelMotorXName.AutoSize = true;
            this.labelMotorXName.Location = new System.Drawing.Point(6, 46);
            this.labelMotorXName.Name = "labelMotorXName";
            this.labelMotorXName.Size = new System.Drawing.Size(38, 13);
            this.labelMotorXName.TabIndex = 12;
            this.labelMotorXName.Text = "Name:";
            // 
            // textBoxMotorXAttached
            // 
            this.textBoxMotorXAttached.Location = new System.Drawing.Point(66, 20);
            this.textBoxMotorXAttached.Name = "textBoxMotorXAttached";
            this.textBoxMotorXAttached.ReadOnly = true;
            this.textBoxMotorXAttached.Size = new System.Drawing.Size(131, 20);
            this.textBoxMotorXAttached.TabIndex = 11;
            // 
            // labelMotorXAttached
            // 
            this.labelMotorXAttached.AutoSize = true;
            this.labelMotorXAttached.Location = new System.Drawing.Point(6, 23);
            this.labelMotorXAttached.Name = "labelMotorXAttached";
            this.labelMotorXAttached.Size = new System.Drawing.Size(53, 13);
            this.labelMotorXAttached.TabIndex = 10;
            this.labelMotorXAttached.Text = "Attached:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "# Steppers";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Version:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Serial No.:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(66, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(66, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(131, 20);
            this.textBox5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Attached:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(66, 239);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(131, 20);
            this.textBox6.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "# Steppers";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(66, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(131, 20);
            this.textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(66, 216);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(131, 20);
            this.textBox8.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Attached:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Version:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Name:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(66, 193);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(131, 20);
            this.textBox9.TabIndex = 35;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(66, 170);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(131, 20);
            this.textBox10.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Serial No.:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 374);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabCalibration.ResumeLayout(false);
            this.tabCalibration.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageArduino.ResumeLayout(false);
            this.tabPageArduino.PerformLayout();
            this.tabPagePhidgetMotors.ResumeLayout(false);
            this.panelMotorX.ResumeLayout(false);
            this.panelMotorX.PerformLayout();
            this.panelMotorsY.ResumeLayout(false);
            this.panelMotorsY.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCalibration;
        private System.Windows.Forms.TabPage tabAcquisition;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label labelArduinoCOMPort;
        private System.Windows.Forms.Button buttonAbortCalibration;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.TextBox textBoxSystemCalibrated;
        private System.Windows.Forms.Label labelSystemCalibrated;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.Windows.Forms.Label labelStatusMessages;
        private System.Windows.Forms.RichTextBox richTextBoxStatusMessages;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageArduino;
        private System.Windows.Forms.TabPage tabPagePhidgetMotors;
        private System.Windows.Forms.TabPage tabPageBridge;
        private System.Windows.Forms.TextBox textBoxArduinoInfoCOMport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArduinoInfoConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonArduinoInfoConnect;
        private System.Windows.Forms.Panel panelMotorX;
        private System.Windows.Forms.Panel panelMotorsY;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMotorsY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMotorXNSteppers;
        private System.Windows.Forms.Label labelMotorXNSteppers;
        private System.Windows.Forms.TextBox textBoxMotorXVersion;
        private System.Windows.Forms.Label labelMotorXVersion;
        private System.Windows.Forms.TextBox textBoxMotorXSerialNo;
        private System.Windows.Forms.Label labelMotorXSerialNo;
        private System.Windows.Forms.TextBox textBoxMotorXName;
        private System.Windows.Forms.Label labelMotorXName;
        private System.Windows.Forms.TextBox textBoxMotorXAttached;
        private System.Windows.Forms.Label labelMotorXAttached;
        private System.Windows.Forms.Label labelMotorX;
    }
}

