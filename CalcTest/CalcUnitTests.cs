using CalcLib;
using NUnit.Framework;

namespace CalcTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
                    
        }

        [Test]
        public void AdditionTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 2;
            Calc.secondNumber = 2;
            double addNum = Calc.AddNumbers();
            Assert.AreEqual(addNum, 4);
        }

        [Test]
        public void SubtractionTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 2;
            Calc.secondNumber = 2;
            double subNum = Calc.SubtractNumbers();
            Assert.AreEqual(subNum, 0);
        }

        [Test]
        public void MultiplicationTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 2;
            Calc.secondNumber = 2;
            double multNum = Calc.MulitplyNumbers();
            Assert.AreEqual(multNum, 4);
        }

        [Test]
        public void DivisionTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 2;
            Calc.secondNumber = 2;
            double divNum = Calc.DivideNumbers();
            Assert.AreEqual(divNum, 1);
        }

        [Test]
        public void DivideByZeroTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 2;
            Calc.secondNumber = 0;
            double divNum = Calc.DivideNumbers();
            Assert.AreEqual(divNum, 0);
        }

        [Test]
        public void RiaseToPowerTest()
        {
            SimpleCalculator Calc = new SimpleCalculator();
            Calc.firstNumber = 4;
            Calc.secondNumber = 2;
            double powerNum = Calc.RaiseToPower();
            Assert.AreEqual(powerNum, 16);
        }
    }
}