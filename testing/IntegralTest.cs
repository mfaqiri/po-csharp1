using System;
using Xunit;
using integral;

namespace testing
{
    public class IntegralTest
    {
        [Fact]
        public void IntegralTest1()
        {
            int result = IntegralClass.integrate(0,2,5);
            Assert.True(result == 3);
        }

        [Fact]
        public void IntegralTest2()
        {
            int result = IntegralClass.integrate(2,4,7);
            Console.WriteLine(result);
            Assert.True(result == 279);
        }

        [Fact]
        public void IntegralTest3()
        {
            int result = IntegralClass.integrate(5,9,3);
            Assert.True(result == -530712);
        }
    }
}
