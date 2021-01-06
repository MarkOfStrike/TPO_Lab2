using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Function_Result;

using NUnit.Framework;

namespace Equation_Test
{
    class FormulaTest
    {
        [Test]
        public void TestMinus1()
        {
            var actual = Function.FunctionResult(-1);
            var expected = 13130.5;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus2()
        {
            var actual = Function.FunctionResult(-2);
            var expected = 3282.1;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus10()
        {
            var actual = Function.FunctionResult(-10);
            var expected = 130.6;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus1()
        {
            var actual = Function.FunctionResult(1);
            var expected = double.NaN;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestPlus2()
        {
            var actual = Function.FunctionResult(2);
            var expected = 0.9;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus5()
        {
            var actual = Function.FunctionResult(5);
            var expected = 1.3;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus10()
        {
            var actual = Function.FunctionResult(10);
            var expected = 1.6;

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}
