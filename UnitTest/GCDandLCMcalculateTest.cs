using System;
using Xunit;

namespace UnitTest
{
    public class GCDandLCMcalculateTest
    {
        [Theory]
        [InlineData(20,50, 10)]
        public void GetGCDofTwoNumber(long numberA, long numberB, long expected)
        {
            var sut = new GCD.GCDcalculate();
            var actual = sut.getGCDofTwoNumber(numberA, numberB);
            Assert.Equal(expected, actual);
        }
    }
}
