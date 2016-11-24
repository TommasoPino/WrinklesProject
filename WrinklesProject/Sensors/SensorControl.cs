using System;
using SensorDefinition;
using System.Threading;
using System.IO.Ports;

namespace SensorControl
{
    class SensorControl
    {
        #region Fields
        // Generic events variables
        public virtual event GenericEventHandler GenericEvent;
        protected EventArgs e = null;
        public delegate void GenericEventHandler(Sensor m, EventArgs e);

        // Text to notify
        public event TextEventHandler Text;
        public delegate void TextEventHandler(string text);


        // Change Textbox Status
        public event ArduinoConnectedHandler ArduinoConnected;
        public delegate void ArduinoConnectedHandler(string obj, bool status);

        // Arduino attaching variables
        protected const string TryConnection = "Connecting to Artuino ...";
        protected const string Connected = "Arduino is connected";
        protected const string NotConnected = "Arduino is not connected";
        protected const string AlreadyConnected = "Arduino is already connected";
        // Serial port Arduino Communication variables
        protected SerialPort serialPort;
        protected const string serialPortObj = "Arduino";
        protected bool serialPortInitialized = false;
        // Thread variable
        protected Thread controlTread;
        #endregion

        #region Properties
        /// <summary>
        /// Return the string of Port Name of serialPort
        /// </summary>
        public string SerialPortName
        {
            get { return serialPort.PortName; }
        }
        /// <summary>
        /// Return the bool of SerialPort status
        /// </summary>
        public bool SerialPortIsOpen
        {
            get { return serialPort.IsOpen; }
        }
        /// <summary>
        /// Return if the Serial Port is Initialized
        /// </summary>
        public bool SerialPortInitialized
        {
            get { return serialPortInitialized; }
        }
        #endregion

        #region Contructor
        public SensorControl()
        {
            serialPort = new SerialPort();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// This Method try to connect to Arduino and return Bool status of connection
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public bool ArduinoConnection(string portName)
        {
            //initialization of serialport object
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = 9600;
                serialPort.ReadTimeout = 10;
                // try to connect to Arduino
                Text?.Invoke(TryConnection);
                try
                {
                    // return true if the Arduino is connect
                    if (!serialPort.IsOpen)
                    {
                        serialPort.Open();
                    }
                    Text?.Invoke(Connected);
                    serialPortInitialized = true;
                    ArduinoConnected?.Invoke(serialPortObj, serialPort.IsOpen);
                    return true;
                }
                catch
                {
                    Text?.Invoke(NotConnected);
                    serialPortInitialized = false;
                    ArduinoConnected?.Invoke(serialPortObj, serialPort.IsOpen);
                    return false;
                }
            }
            else
            {
                Text?.Invoke(AlreadyConnected);
                serialPortInitialized = true;
                ArduinoConnected?.Invoke(serialPortObj, serialPort.IsOpen);
                return true;
            }
        }

        protected void TextInvoke(string text)
        {
            Text?.Invoke(text);
        }
        #endregion
    }
}
