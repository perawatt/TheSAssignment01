using System;

namespace LCM
{
    public class LCMcalculate : ILCMcalculate
    {
        public long calculateLCMofTwoNumber(long numberA, long numberB)
        {
            var gcdSvc = new GCD.GCDcalculate();
            var gcd = gcdSvc.calculateGCDofTwoNumber(numberA, numberB);
            return (numberA * numberB) / gcd;
        }
    }
}
