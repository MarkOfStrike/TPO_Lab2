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
            for (double i = -20; i < 20; i+=0.1)
            {
                var num = Equation.ConvertRadiant(i);

                Assert.AreEqual(Math.Sin(num), Equation.Sin(num), 0.000000001);
            }
        }

        [Test]
        public void TestCos()
        {
            for (int i = -20; i < 20; i++)
            {
                var num = Equation.ConvertRadiant(i);

                Assert.AreEqual(Math.Cos(num), Equation.Cos(num), 0.001);
            }
        }

        [Test]
        public void TestFact()
        {
            Assert.AreEqual(720, Equation.Fact(6));
            Assert.AreEqual(2, Equation.Fact(2));
            Assert.AreEqual(24, Equation.Fact(4));
        }

        [Test]
        public void TestTan()
        {
            for (double i = -20; i < 20; i += 0.1)
            {
                var num = Equation.ConvertRadiant(i);

                Assert.AreEqual(Math.Tan(num), Equation.Tan(num), 0.00000001);
            }
        }

        [Test]
        public void TestCot()
        {
            for (double i = -20; i < 20; i += 0.1)
            {
                var num = Equation.ConvertRadiant(i);

                Assert.AreEqual(1 / Math.Tan(num), Equation.Cot(num), 0.00001);
            }
        }

        [Test]
        public void TestLog()
        {
            Random ran = new Random();

            for (double i = 1; i < 40; i++)
            {
                for (double j = 2; j < 10; j++)
                {
                    Assert.AreEqual(Math.Log(i, j), Equation.Log(i, j), 0.001);
                }
            }
        }

        [Test]
        public void TestLn()
        {
            for (int i = -20; i < 20; i++)
            {
                Assert.AreEqual(Math.Log(i), Equation.Ln(i), 0.001);
            }
        }

        [Test]
        public void TestExp()
        {
            for (double i = 1; i < 10; i += 0.1)
            {
                Assert.AreEqual(Math.Exp(i), Equation.Exp(i), 1);
            }
            
        }

        [Test]
        public void TestLg()
        {
            for (double i = 1; i < 40; i += 0.1)
            {
                Assert.AreEqual(Math.Log10(i), Equation.Lg(i), 0.001);
            }
        }

        [Test]
        public void TestPow()
        {
            for (double i = 1; i < 10; i += 0.1)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(Math.Pow(i, j), Equation.Pow(i,j), 0.000001);
                }
            }
        }

        [Test]
        public void TestSqrt()
        {
            for (double i = 1; i < 150; i++)
            {
                Assert.AreEqual(Math.Sqrt(i), Equation.Sqrt(i), 0.001);
            }
        }

        [Test]
        public void TestAbs()
        {
            Random ran = new Random();

            for (int i = 0; i < 20; i++)
            {
                var num = ran.Next(-500, 100);
                Assert.AreEqual(Math.Abs(num), Equation.Abs(num));
            }
        }

        [Test]
        public void TestConvertRadian()
        {
            Assert.AreEqual(0.9599, Equation.ConvertRadiant(55),0.001);
        }

        [Test]
        public void TestRound()
        {
            Random ran = new Random();
            for (int i = 0; i < 20; i++)
            {
                var num = ran.NextDouble() * 10;

                Assert.AreEqual(Math.Round(num, 2), Equation.Rounding(num, 2), 0.01);
            }
        }
    }
}
