using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Auto_2022;
using System;

namespace MSTest_Auto_2022
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetUp()
        {
            Console.WriteLine("Before every test");
        }
        [TestMethod]
        [DataRow(100,200,'+',300)]
        [DataRow(100, -200, '+', -100)]
        [DataRow(-100, -200, '+', -300)]
        [DataRow(100, 0, '+', 100)]

        public void TestMethod1(double a, double b, char op, double result)
        {
            Console.WriteLine("Testing...");
            Calculator c = new Calculator(a, b, op);
            Assert.AreEqual(result, c.Compute()); 

        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("After every test");
        }
    }
}
