using System;

using Equation_Library;

using NUnit.Framework;

namespace Equation_Test
{
    [TestFixture]
    public class EquationTest
    {

        [SetUp]
        public void Initialization()
        {


        }

        [Test]
        public void TestSin()
        {
            var num = Equation.ConvertRadiant(5);

            Assert.AreEqual(Math.Sin(num), Equation.Sin(num));
        }

        [Test]
        public void TestCos()
        {
            var num = Equation.ConvertRadiant(-23);

            Assert.AreEqual(Math.Cos(num), Equation.Cos(num),0.001);
        }

        [Test]
        public void TestFact()
        {
            Assert.AreEqual(720, Equation.Fact(6));
        }

        [Test]
        public void TestTan()
        {
            var num = Equation.ConvertRadiant(5);

            Assert.AreEqual(Math.Tan(num), Equation.Tan(num));
        }

        [Test]
        public void TestCot()
        {
            var num = Equation.ConvertRadiant(5);

            Assert.AreEqual(1 / Math.Tan(num), Equation.Cot(num));
        }

        [Test]
        public void TestLog()
        {
            Assert.AreEqual(Math.Log(23, 4), Equation.Log(23, 4),0.001);
        }

        [Test]
        public void TestLn()
        {
            Assert.AreEqual(Math.Log(7), Equation.Ln(7),0.001);
        }

        [Test]
        public void TestExp()
        {
            Assert.AreEqual(Math.Exp(6), Equation.Exp(6),0.001);
        }

        [Test]
        public void TestLg()
        {
            Assert.AreEqual(Math.Log10(20), Equation.Lg(20),0.001);
        }

        [Test]
        public void TestPow()
        {
            Assert.AreEqual(Math.Pow(5, 7), Equation.Pow(5, 7));
        }

        [Test]
        public void TestSqrt()
        {
            Assert.AreEqual(Math.Sqrt(87), Equation.Sqrt(87));
        }

        [Test]
        public void TestAbs()
        {
            Assert.AreEqual(Math.Abs(-46), Equation.Abs(-46));
        }

        [Test]
        public void TestConvertRadian()
        {
            Assert.AreEqual(0.9599, Equation.ConvertRadiant(55),0.001);
        }

        [Test]
        public void TestRound()
        {
            Assert.AreEqual(4.55, Equation.Rounding(4.5468, 2), 0.01);
        }
    }
}
