using Phidgets;
using System.Collections;
using System.Collections.Generic;

namespace StepperMotorControl
{
    class StepperMotorControl
    {
        #region Fields
        // Constant Velocity and Acceleration
        const double MaxVelocityCalibration = 0;
        const double MaxAccelerationCalibration = 0;

        const double MaxVelocityScanner = 0;
        const double MaxAccelerationScanner = 0;

        double maxVelocityBreaking;
        double maxAccelerationBreaking;

        // serial number of phidget boards
        const int SerialNumberX  = 401567;  // CHECKED
        const int SerialNumberY1 = 421034;  // CHECKED
        const int SerialNumberY2 = 423642;  // CHECKED

        // NumOfMotor and their label
        const int NumberOfMotors = 3;
        string[] MotorNameLabel = { "XMotor", "YMotor1", "YMotor2" };
        // Other varaibles
        const int AttachmentWaitingTime = 1000;
        List<Stepper> steppers = new List<Stepper>();
        // Events that returns TEXT for the RichTextBox

        #endregion

        #region Public Properties
        
        #endregion

        #region Private Properties
        public double MaxVelocityBreaking
        {
            private set { maxVelocityBreaking = value; }
            get { return maxVelocityBreaking; }
        }
        public double MaxAccelerationBreaking
        {
            private set { maxAccelerationBreaking = value; }
            get { return maxAccelerationBreaking; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// The Control Motor Constructor
        /// </summary>
        public StepperMotorControl()
        {
            InizializationMotors();
        }
        #endregion

        #region Public Methods
        public void StopMotor(string label)
        {
            foreach (Stepper stepper in steppers)
            {
                if (stepper.Label == label)
                {
                    // Set the velocity to 
                    stepper.steppers[0].Acceleration   = stepper.steppers[0].AccelerationMax;
                    stepper.steppers[0].VelocityLimit  = stepper.steppers[0].VelocityMax;
                    stepper.steppers[0].TargetPosition = stepper.steppers[0].TargetPosition;
                }
            }
        }
        #endregion

        #region Public Methods
        
        #endregion

        #region Private Methods
        /// <summary>
        /// This method Initialized all motors
        /// </summary>
        private void InizializationMotors()
        {
            for (int i = 0; i < NumberOfMotors; i++)
            {
                steppers[i] = new Stepper();
                steppers[i].waitForAttachment(AttachmentWaitingTime);
            }
            MaxVelocityBreaking = steppers[0].steppers[0].VelocityMax;
            MaxAccelerationBreaking = steppers[0].steppers[0].AccelerationMax;
            CheckSerialNumbers(steppers);
        }

        /// <summary>
        /// This method verify that no motor inverts with other
        /// </summary>
        /// <param name="steppers"></param>
        private void CheckSerialNumbers(List<Stepper> steppers)
        {
            foreach (Stepper stepper in steppers)
            {
                switch (stepper.SerialNumber)
                {
                    case SerialNumberX:
                        stepper.Label = MotorNameLabel[0];
                        break;
                    case SerialNumberY1:
                        stepper.Label = MotorNameLabel[1];
                        break;
                    case SerialNumberY2:
                        stepper.Label = MotorNameLabel[2];
                        break;
                }
            }
        }
        #endregion
    }
}
