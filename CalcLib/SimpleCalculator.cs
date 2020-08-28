using System;

namespace CalcLib
{
    public class SimpleCalculator
    {
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public double result { get; set; }
        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <returns>double</returns>
        public double Add()
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// subtracts two numbers
        /// </summary>
        /// <returns>double</returns>
        public double Subtract()
        { 
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <returns>double</returns>
        public double Mulitply()
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <returns>double</returns>
        public double Divide()
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            return 0;
        }

        /// <summary>
        /// takes a number and raises it to a power
        /// </summary>
        /// <returns>double</returns>
        public double RaiseToPower()
        {
           return Math.Pow(firstNumber, secondNumber);
        }
    }
}
