using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDefinition
{
    /// <summary>
    /// Class oriented to contact sensor
    /// </summary>
    class LimitSwitchContactSensor:Sensor
    {
        #region Field
        public event EventHandler ContactEvent;

        // Variable delegated to store the limit switch status
        bool constactStatus;
        #endregion

        #region Properties
        /// <summary>
        /// Retrun a bool with contactStatus
        /// </summary>
        public bool getContactStatus
        {
            get { return constactStatus; }
        }

        #endregion

        #region Costructor
        /// <summary>
        /// Create a Limit Switch Contact Sensor
        /// </summary>
        /// <param name="sensorName"></param>
        public LimitSwitchContactSensor(string sensorName)
            : base(sensorName,true,SensorType.contactSensor)
        { }
        #endregion

        #region Method
        /// <summary>
        /// This method verify if the sensor's status is change. If true start the EVENT
        /// </summary>
        /// <param name="sensorName"></param>
        /// <param name="constactStatus"></param>
        public void isStatusChanged(string sensorName, bool constactStatus)
        {
            if (this.sensorName == sensorName)
            {
                if (this.constactStatus != constactStatus)
                {
                    this.constactStatus = constactStatus;
                    if (this.constactStatus == true)
                    {
                        ContactEvent(this, e);
                    }
                }
            }
        }

        #endregion

    }
}
