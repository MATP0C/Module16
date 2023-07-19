using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionTest()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractionTest()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(20, 10);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void MultiplicationTest()
        {
            var calculator = new Calculator();
            int result = calculator.Miltiplication(100, 2);
            Assert.AreEqual(200, result);
        }

        [Test]
        public void DivisionTest()
        {
            var calculator = new Calculator();
            int result = calculator.Division(25, 5);
            Assert.AreEqual(5, result);
        }
    }
}
