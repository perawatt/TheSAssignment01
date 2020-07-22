using System;
using Xunit;

namespace XUnitTest
{
    public class GCDandLCMcalculateTest
    {
        [Theory]
        [InlineData(20, 50, 10)]
        [InlineData(50, 135, 5)]
        public void CalculateGCDofTwoNumberTest(long numberA, long numberB, long expected)
        {
            var sut = new GCD.GCDcalculate();
            var actual = sut.calculateGCDofTwoNumber(numberA, numberB);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 15, 60)]
        [InlineData(30, 122, 1830)]
        [InlineData(50, 10, 50)]
        public void CalculateLCMofTwoNumberTest(long numberA, long numberB, long expected)
        {
            var sut = new LCM.LCMcalculate();
            var actual = sut.calculateLCMofTwoNumber(numberA, numberB);
            Assert.Equal(expected, actual);
        }
    }
}
