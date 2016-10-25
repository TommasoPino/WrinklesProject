using System;

/// <summary>
/// This namespace is going to define all tipology of sensor used in this project
/// </summary>
namespace SensorDefinition
{
    /// <summary>
    /// Parent class Sensor
    /// </summary>
    class Sensor
    {
        #region Fields
        // event, EventArgs and delegate for general the Event
        public virtual event EventHandler Event;
        protected EventArgs e = null;
        public delegate void EventHandler(Sensor m, EventArgs e);

        protected string sensorName;
        protected bool sensorConnected;
        double sensorValue;
        protected SensorType sensorType;
        #endregion

        #region Properties

        /// <summary>
        /// Return the sensorName
        /// </summary>
        public virtual string GetSensorName
        {
            get { return sensorName; }
        }

        /// <summary>
        /// Return the sensorStatus
        /// </summary>
        public virtual bool GetSensorConnected
        {
            get { return sensorConnected; }
        }

        /// <summary>
        /// Return the sensorValue
        /// </summary>
        public virtual double GetSensorValue
        {
            get { return sensorValue; }
        }
        #endregion

        #region Contructor
        public Sensor() : this("GenericSensor",false,SensorType.genericSensor)
        { }
        public Sensor(string sensorName, bool sensorConnected) 
            : this (sensorName, sensorConnected,SensorType.genericSensor)
        { }
        public Sensor(string sensorName, bool sensorConnected, SensorType sensorType) 
        {
            this.sensorName = sensorName;
            this.sensorConnected = sensorConnected;
            this.sensorType = sensorType;
        }
        #endregion

        #region Methods

        #endregion

    }

    /// <summary>
    /// Enumeration for sensor tipology
    /// </summary>
    enum SensorType
    {
        genericSensor,
        contactSensor,
        weightSensor,
        laserSensor,
    }
}
