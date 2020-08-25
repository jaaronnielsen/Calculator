﻿using System;

namespace CalcLib
{
    public class Calculator
    {
        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// subtracts two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public int Mulitply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            return 0;
        }
    }
}
