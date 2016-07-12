using Util;
using System;

 /*
Project: BMI Calculator
Programmer: Eric Kristiansen
Date: 7/11/16
*/
namespace BodyMassIndex
{
    /// //////////////////////////////////////////////////////////
    /// <summary>
    /// This class is intended to be used for validation purposes
    /// </summary>
    /// //////////////////////////////////////////////////////////
    public class ValidationData
    {
        private const string UNDERWEIGHT = "underweight";
        private const string NORMAL = "normal";
        private const string OVERWEIGHT = "overweight";
        private const string OBESE = "obese";
        private const double MAX_UNDERWEIGHT = 18.49;
        private const double MAX_NORMAL = 24.99;
        private const double MAX_OVERWEIGHT = 29.99;

        private const int BMI_FACTOR = 703;
        private float height { get; set; }
        private float weight { get; set; }
        private bool isValidated;
        private double calculatedBMI;
        private string diagnosis = "";

        /// <summary>
        /// gets the diagnosis based on the calculated BMI
        /// </summary>
        /// <returns name="diagnosis"></returns>
        public string getDiagnosis()
        {
            if (calculatedBMI <= MAX_UNDERWEIGHT)
            {
                diagnosis = UNDERWEIGHT;
            }
            else if (calculatedBMI <= MAX_NORMAL)
            {
                diagnosis = NORMAL;
            }
            else if (calculatedBMI <= MAX_OVERWEIGHT)
            {
                diagnosis = OVERWEIGHT;
            }
            else
            {
                diagnosis = OBESE;
            }
            return diagnosis;
        }


        /// ////////////////////////////////////////////////////////
        /// <summary>
        /// simply set isValidated to false on class initialization
        /// </summary>
        /// ////////////////////////////////////////////////////////
        public ValidationData() { isValidated = false; }


        /// //////////////////////////////////////////////////////
        /// <summary>
        /// called to populate the isValidated bool appropriately
        /// </summary>
        /// //////////////////////////////////////////////////////
        public void validateData()
        {
            isValidated = (height != Utilities.NEGATIVE_ONE && weight != Utilities.NEGATIVE_ONE);
        }


        /// ///////////////////////////////////////////////////
        /// <summary>Perform the calculation of data</summary>
        /// ///////////////////////////////////////////////////
        public void calculateBodyMassIndex()
        {
            calculatedBMI = weight * BMI_FACTOR / Math.Pow(height, Utilities.SQUARE_EXPONENT);
        }


        /// ////////////////////////////////////////////////////
        /// <summary>simple setter for height</summary>
        /// <param name="passHeight"></param>
        /// ///////////////////////////////////////////////////
        public void setHeight(float passHeight)
        { height = passHeight; }


        /// ////////////////////////////////////////////////////
        /// <summary>simple setter for weight</summary>
        /// <param name="passWeight"></param>
        /// ////////////////////////////////////////////////////
        public void setWeight(float passWeight)
        { weight = passWeight; }

        /// ///////////////////////////////////////////////////
        /// <summary>simple getter for calculatedBMI</summary>
        /// <returns name="calculatedBMI"></returns>
        /// ///////////////////////////////////////////////////
        public double getCalculateBMI()
        { return calculatedBMI; }


        /// /////////////////////////////////////////////////
        /// <summary>simple getter for isValidated</summary>
        /// <returns name="isValidated"></returns>
        /// /////////////////////////////////////////////////
        public bool getIsValidated()
        { return isValidated; }
    }
}
