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
            var num = Equation.ConvertRadiant(5);

            Assert.AreEqual(Equation.Rounding(Math.Cos(num),3), Equation.Rounding(Equation.Cos(num),3));
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
            Assert.AreEqual(Equation.Rounding(Math.Log(23, 4),4), Equation.Rounding(Equation.Log(23, 4),4));
        }

        [Test]
        public void TestLn()
        {
            Assert.AreEqual(Equation.Rounding(Math.Log(7),4), Equation.Rounding(Equation.Ln(7),4));
        }

        [Test]
        public void TestExp()
        {
            Assert.AreEqual(Equation.Rounding(Math.Exp(6),3), Equation.Rounding(Equation.Exp(6),3));
        }

        [Test]
        public void TestLg()
        {
            Assert.AreEqual(Equation.Rounding(Math.Log10(20), 4), Equation.Rounding(Equation.Lg(20), 4));
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
            Assert.AreEqual(Math.Round(0.9599, 4), Math.Round(Equation.ConvertRadiant(55), 4));
        }

        [Test]
        public void TestRound()
        {
            Assert.AreEqual(4.54, Equation.Rounding(4.5468, 2));
        }
    }
}
