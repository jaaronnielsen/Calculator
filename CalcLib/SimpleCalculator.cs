using System;
using System.ComponentModel;

namespace CalcLib
{
    public class SimpleCalculator : ICloneable, IDataErrorInfo
    {
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public double result { get; set; }

        public string Error => throw new NotImplementedException();

        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <returns>double</returns>
        public double AddNumbers()
        {
            result = firstNumber + secondNumber;
            return result;
        }

        /// <summary>
        /// subtracts two numbers
        /// </summary>
        /// <returns>double</returns>
        public double SubtractNumbers()
        { 
            result = firstNumber - secondNumber;
            return result;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <returns>double</returns>
        public double MulitplyNumbers()
        {
            result = firstNumber * secondNumber;
            return result;
        }

        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <returns>double</returns>
        public double DivideNumbers()
        {
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                return result;
            }
            return 0;
        }

        /// <summary>
        /// takes a number and raises it to a power
        /// </summary>
        /// <returns>double</returns>
        public double RaiseToPower()
        {
            result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

        public object Clone()
        {
            return new SimpleCalculator()
            {
                firstNumber = firstNumber,
                secondNumber = secondNumber,
                result = result,
            };
        }

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case nameof(firstNumber):
                        if (firstNumber == 0)
                        {
                            return "This number can't be zero.";
                        }
                        break;
                    case nameof(secondNumber):
                        if (secondNumber == 0)
                        {
                            return "This number can't be zero.";
                        }
                        break;
                    default:
                        break;
                }
                return string.Empty;
            }
        }
    }
}
