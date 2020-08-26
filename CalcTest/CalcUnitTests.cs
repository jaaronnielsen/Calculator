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
            Calculator Calc = new Calculator();
            int addNum = Calc.Add(2, 2);
            Assert.AreEqual(addNum, 4);
        }

        [Test]
        public void SubtractionTest()
        {
            Calculator Calc = new Calculator();
            int subNum = Calc.Subtract(2, 2);
            Assert.AreEqual(subNum, 0);
        }

        [Test]
        public void MultiplicationTest()
        {
            Calculator Calc = new Calculator();
            int multNum = Calc.Mulitply(2, 2);
            Assert.AreEqual(multNum, 4);
        }

        [Test]
        public void DivisionTest()
        {
            Calculator Calc = new Calculator();
            int divNum = Calc.Divide(2, 2);
            Assert.AreEqual(divNum, 1);
        }

        [Test]
        public void DivideByZeroTest()
        {
            Calculator Calc = new Calculator();
            int divNum = Calc.Divide(2, 0);
            Assert.AreEqual(divNum, 0);
        }

        [Test]
        public void RiaseToPowerTest()
        {
            Calculator Calc = new Calculator();
            double powerNum = Calc.RaiseToPower(4, 2);
            Assert.AreEqual(powerNum, 16);
        }
    }
}