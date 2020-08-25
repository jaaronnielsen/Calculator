using System;

namespace CalcLib
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Mulitply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
