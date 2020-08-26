using System;

namespace CalcLib
{
    public class Calculator
    {
        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>double</returns>
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// subtracts two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>double</returns>
        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>double</returns>
        public double Mulitply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>double</returns>
        public double Divide(double firstNumber, double secondNumber)
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
        /// <param name="number"></param>
        /// <param name="power"></param>
        /// <returns>double</returns>
        public double RaiseToPower(double number, double power)
        {
           return Math.Pow(number, power);
        }
    }
}
