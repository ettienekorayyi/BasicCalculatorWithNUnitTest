using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using BasicCalculatorWithNUnitTest.Utility;

namespace BasicCalculatorTest
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void AddTest()
        {
            Assert.AreEqual(5, new MathHelper().Add(2, 3));   
        }
        [TestCase]
        public void SubtractTest()
        {
            Assert.AreEqual(-1, new MathHelper().Subtract(2, 3));
        }
        [TestCase]
        public void DivideTest()
        {
            Assert.AreEqual(0, new MathHelper().Divide(2, 3));
        }
        [TestCase]
        public void MultiplyTest()
        {
            Assert.AreEqual(6, new MathHelper().Multiply(2, 3));
        }
    }
}
