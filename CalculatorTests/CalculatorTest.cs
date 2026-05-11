using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class SimpleCalculatorTests
    {
        private readonly ISimpleCalculator _calc = new SimpleCalculator();

        [TestMethod]
        public void Add_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(7, _calc.Add(3, 4));
        }

        [TestMethod]
        public void Add_WithNegativeNumbers_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(-1, _calc.Add(3, -4));
        }

        [TestMethod]
        public void Add_WithZero_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(5, _calc.Add(5, 0));
        }

        [TestMethod]
        public void Add_ShouldThrowOverflowException()
        {
            Assert.ThrowsException<OverflowException>(() =>
                _calc.Add(int.MaxValue, 1));
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(2, _calc.Subtract(5, 3));
        }

        [TestMethod]
        public void Subtract_WithNegativeNumbers_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(8, _calc.Subtract(5, -3));
        }

        [TestMethod]
        public void Subtract_WithZero_ShouldReturnCorrectResult()
        {
            Assert.AreEqual(5, _calc.Subtract(5, 0));
        }

        [TestMethod]
        public void Subtract_ShouldThrowOverflowException()
        {
            Assert.ThrowsException<OverflowException>(() =>
                _calc.Subtract(int.MinValue, 1));
        }
    }
}