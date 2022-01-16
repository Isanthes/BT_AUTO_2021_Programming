using NUnit_Auto_2022;
using System;
using Xunit;
using Xunit.Abstractions;

namespace XUnit_Auto_2022
{
    public class UnitTest1 : IDisposable
    {
        private readonly ITestOutputHelper testOutputHelper;
        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup every test");
        }

        public void Dispose()
        {
            testOutputHelper.WriteLine("TearDown!");
        }

        [Theory]
        [InlineData(50, 100, '-', -50)]
        [InlineData(50, -100, '-', 150)]
       
        public void Test1(double a, double b, char op, double result)
        {
            testOutputHelper.WriteLine("My test");
            Calculator c = new Calculator(a, b, op);
            Assert.Equal(result, c.Compute());
        }

      
    }
}
