using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 15, 20)]
        [TestCase(-5, 5, 0)]
        public void TestAddition(int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Ignored for demo")]
        public void IgnoreTest()
        {
        }
    }
}