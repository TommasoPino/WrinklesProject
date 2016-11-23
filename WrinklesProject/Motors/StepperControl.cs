using Phidgets;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using Calibration_v0_2;

namespace StepperControl
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

        bool calibrationAbort = false;
        bool calibrationDone = false;

        bool inizializationMotorsStatus = false;

        // serial number of phidget boards
        const int SerialNumberX  = 401567;  // CHECKED
        const int SerialNumberY1 = 421034;  // CHECKED
        const int SerialNumberY2 = 423642;  // CHECKED

        // limit variables
        long xLimitMin;
        long xLimitMax;

        long yLimitMin;
        long yLimitMax;

        // NumOfMotor and their label
        const int NumberOfMotors = 3;
        string[] MotorNameLabel = { "XMotor", "YMotor1", "YMotor2" };
        // Other varaibles
        const int AttachmentWaitingTime = 100;
        List<Stepper> steppers = new List<Stepper>();
        const string AttachmentProblem = "Attachment problem";
        // Events that returns TEXT for the RichTextBox
        public event TextEventHandler Text;
        public delegate void TextEventHandler(string text);

        public event ResetButtonsCalibrationHandler ResetButtonsCalibration;
        public delegate void ResetButtonsCalibrationHandler();

        Exception e;

        // Delegate

        // Threading
        Thread calibrationThread;
        #endregion

        #region Public Properties

        #endregion

        #region Partial Properties
        public bool CalibrationDone
        {
            private set { calibrationDone = value; }
            get { return calibrationDone; }
        }

        public bool CalibrationAbort
        {
            private set { calibrationAbort = value; }
            get { return calibrationAbort; }
        }

        public bool InizializationMotorsStatus
        {
            private set { inizializationMotorsStatus = value; }
            get { return inizializationMotorsStatus; }
        }
        /// <summary>
        /// This Property is used to set the breaking velocity
        /// </summary>
        public double MaxVelocityBreaking
        {
            private set { maxVelocityBreaking = value; }
            get { return maxVelocityBreaking; }
        }
        /// <summary>
        /// This Property is used to set the breaking acceleration
        /// </summary>
        public double MaxAccelerationBreaking
        {
            private set { maxAccelerationBreaking = value; }
            get { return maxAccelerationBreaking; }
        }
        /// <summary>
        /// These Properties are used during calibration to set the working
        /// area
        /// XLimitMin , YLimitMin , XLimitMax , YLimitMax
        /// </summary>
        public long XLimitMin
        {
            private set { xLimitMin = value; }
            get { return xLimitMin; }
        }
        /// <summary>
        /// These Properties are used during calibration to set the working
        /// area
        /// XLimitMin , YLimitMin , XLimitMax , YLimitMax
        /// </summary>
        public long XLimitMax
        {
            private set { xLimitMax = value; }
            get { return xLimitMax; }
        }
        /// <summary>
        /// These Properties are used during calibration to set the working
        /// area
        /// XLimitMin , YLimitMin , XLimitMax , YLimitMax
        /// </summary>
        public long YLimitMin
        {
            private set { yLimitMin = value; }
            get { return yLimitMin; }
        }
        /// <summary>
        /// These Properties are used during calibration to set the working
        /// area
        /// XLimitMin , YLimitMin , XLimitMax , YLimitMax
        /// </summary>
        public long YLimitMax
        {
            private set { yLimitMax = value; }
            get { return yLimitMax; }
        }
        #endregion


        #region Constructor
        /// <summary>
        /// The Control Motor Constructor
        /// </summary>
        public StepperMotorControl()
        {
            try
            {
                InizializationMotors();
            }
            catch { }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Stop specific motor
        /// </summary>
        /// <param name="label"></param>
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
        /// <summary>
        /// Stop all motors
        /// </summary>
        public void StopAllMotors()
        {
            foreach (Stepper stepper in steppers)
            {
                StopMotor(stepper.Label);
                Text?.Invoke(stepper.Label + " is stopped");
            }
        }

        public void StartCalibration()
        {
            if (calibrationThread == null)
            {
                calibrationThread = new Thread(Calibration);
            }
        }

        public void CloseThreadCalibration()
        {
            if (calibrationThread.ThreadState == ThreadState.Stopped)
            {
                calibrationThread.Abort();
                calibrationThread.Interrupt();
                calibrationThread.Join();
                calibrationThread = null;
            }
        }

        public void AbortCalibration()
        {
            CalibrationAbort = true;
            StopAllMotors();
        }
        /// <summary>
        /// Return a boolean if all motors are stopped
        /// </summary>
        /// <param name="steppers"></param>
        /// <returns></returns>
        public bool AllMotorStop(List<Stepper> steppers)
        {
            bool result = true;
            foreach (Stepper stepper in steppers)
            {
                if (!stepper.steppers[0].Stopped)
                {
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// This method Initialized all motors
        /// </summary>
        public void InizializationMotors()
        {
            if (!InizializationMotorsStatus)
            {
                try
                {
                    for (int i = 0; i < NumberOfMotors; i++)
                    {
                        steppers[i] = new Stepper();
                        steppers[i].waitForAttachment(AttachmentWaitingTime);
                        Text?.Invoke(steppers[i].SerialNumber.ToString() + " Attached");
                    }
                    MaxVelocityBreaking = steppers[0].steppers[0].VelocityMax;
                    MaxAccelerationBreaking = steppers[0].steppers[0].AccelerationMax;
                    CheckSerialNumbers(steppers);
                    InizializationMotorsStatus = true;
                }
                catch
                {
                    Text?.Invoke("Check Motor Boards Connection");
                    InizializationMotorsStatus = false;
                    ResetButtonsCalibration();
                }
            }
        }
        #endregion

        #region Private Methods

        private void Calibration()
        {
            foreach (Stepper stepper in steppers)
            {
                EngageMotor(stepper);
                ResetPosition(stepper);
            }

            foreach (Stepper stepper in steppers)
            {
                SetParameterCalibration(stepper);
            }

            // go to minimus
            foreach (Stepper stepper in steppers)
            {
                stepper.steppers[0].TargetPosition = stepper.steppers[0].PositionMin;
            }

            while (!AllMotorStop(steppers) || !calibrationAbort) { }

            if (!calibrationAbort)
            {
                SetPositionLimit(steppers, "min");

                // go to maximus
                foreach (Stepper stepper in steppers)
                {
                    stepper.steppers[0].TargetPosition = stepper.steppers[0].PositionMax;
                }

                while (!AllMotorStop(steppers) || !calibrationAbort) { }
                if (!calibrationAbort)
                {
                    SetPositionLimit(steppers, "max");

                    // disengage all motors
                    foreach (Stepper stepper in steppers)
                    {
                        DisEngageMotor(stepper);
                    }
                    CalibrationDone = true;
                }
            }
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

        /// <summary>
        /// Engage motor and it becames to be able to move.
        /// </summary>
        /// <param name="stepper"></param>
        private void EngageMotor(Stepper stepper)
        {
            if (!stepper.steppers[0].Engaged && stepper.steppers[0].Stopped)
            {
                stepper.steppers[0].Engaged = true;
                Text?.Invoke(stepper.Label + " Engaged");
            }
        }

        /// <summary>
        /// Disengage motor and it becames to be NOT able to move.
        /// The motor MUST to be stopped
        /// </summary>
        /// <param name="stepper"></param>
        private void DisEngageMotor(Stepper stepper)
        {
            if (stepper.steppers[0].Engaged && stepper.steppers[0].Stopped)
            {
                stepper.steppers[0].Engaged = false;
                Text?.Invoke(stepper.Label + " Disengaged");
            }
        }

        /// <summary>
        /// This method reset the current position to zero
        /// </summary>
        /// <param name="stepper"></param>
        private void ResetPosition(Stepper stepper)
        {
            stepper.steppers[0].CurrentPosition = 0;
            Text?.Invoke(stepper.Label + " current position set to zero");
        }

        /// <summary>
        /// this method is used to set the acceleration and velocity 
        /// for the calibration (max both)
        /// </summary>
        /// <param name="stepper"></param>
        private void SetParameterCalibration(Stepper stepper)
        {
            stepper.steppers[0].VelocityLimit = stepper.steppers[0].VelocityMax / 2;
            stepper.steppers[0].Acceleration = stepper.steppers[0].AccelerationMax / 2;
        }

        private void SetPositionLimit(List<Stepper> steppers, string limit)
        {
            long positionX = 0;
            long positionY = 0;
            foreach (Stepper stepper in steppers)
            {
                switch (stepper.Label[0])
                {
                    case 'X':
                        positionX = stepper.steppers[0].CurrentPosition;
                        Text?.Invoke(stepper.Label + " current position limit set");
                        break;
                    case 'Y':
                        positionY = stepper.steppers[0].CurrentPosition;
                        Text?.Invoke(stepper.Label + " current position limit set");
                        break;
                }

                switch (limit)
                {
                    case "min":
                        XLimitMin = positionX;
                        YLimitMin = positionY;
                        break;
                    case "max":
                        XLimitMax = positionX;
                        YLimitMax = positionY;
                        break;
                }
            }
        }
        #endregion
    }
}
