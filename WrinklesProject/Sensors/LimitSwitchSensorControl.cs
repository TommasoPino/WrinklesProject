using SensorDefinition;
using System.Threading;
using System.Collections.Generic;
using System;

namespace SensorControl
{
    /// <summary>
    /// This class create a controller for the contact Sensor
    /// This class depends from the hard
    /// </summary>
    class LimitSwitchSensorControl : SensorControl
    {
        #region Fields
        public event ContactEventHandler ContactEvent;
        public delegate void ContactEventHandler(Sensor m, EventArgs e);


        List<LimitSwitchContactSensor> limitSwitchContactSensors = 
            new List<LimitSwitchContactSensor>();

        string[] sensorName = { "Xminimum" ,
                                "Xmaximum" ,
                                "Yminimum" ,
                                "Ymaximum" ,
                                "Zminimum" ,
                                "Zmaximum" };
        bool interruptThread = false;
        #endregion

        #region Properties
        
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numOfSensor"></param>
        public LimitSwitchSensorControl(int numOfSensor)
            :base()
        {
            for (int i = 0; i < numOfSensor; i++)
            {
                limitSwitchContactSensors.Add(
                    new LimitSwitchContactSensor(sensorName[i]));
                limitSwitchContactSensors[i].ContactEvent += 
                    new Sensor.EventHandler(SensorSwitch);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Stop the thread of control
        /// </summary>
        public void StopControl()
        {
            if (controlTread != null)
            {
                interruptThread = true;
                Thread.Sleep(10);
                controlTread.Interrupt();
                controlTread.Abort();
                controlTread.Join();
                controlTread = null;
            }
        }
        
        /// <summary>
        /// Start the thread of control
        /// </summary>
        public void StartControl()
        {
            if (controlTread == null)
            {
                controlTread = new Thread(ThreadControl); // Add name of main control thread
                controlTread.Name = "LimitSwitchSensorControl";
                controlTread.Start();
            }
        }
        
        /// <summary>
        /// The mail core on the controller
        /// </summary>
        private void ThreadControl()
        {
            // Start the serial sensor Control
            while (!interruptThread)
            {
                // if the serial port is open check the new message
                if (serialPort.IsOpen)
                {
                    try
                    {
                        // read the new income message and identify sensorName and sensorStatus
                        string readString = serialPort.ReadLine();
                        int equalPosition = readString.IndexOf('=');
                        string sensorName = readString.Substring(0, equalPosition);
                        readString = readString.Substring(equalPosition + 1);
                        bool sensorStatus = bool.Parse(readString);
                        // Check if same sensore change
                        foreach (LimitSwitchContactSensor sensor in limitSwitchContactSensors)
                        {
                            sensor.isStatusChanged(sensorName, sensorStatus);
                        }
                        // test
                        TextInvoke("we recive a message");
                    }
                    catch { }                    
                }
            }
            serialPort.Close();
        }

        private void SensorSwitch(Sensor sensor, EventArgs e)
        {
            ContactEvent(sensor, e);
        }
        #endregion
    }
}
