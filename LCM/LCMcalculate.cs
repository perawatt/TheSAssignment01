using System;

namespace LCM
{
    public class LCMcalculate : ILCMcalculate
    {
        public long CalculateLCMofTwoNumber(long numberA, long numberB)
        {
            var gcdSvc = new GCD.GCDcalculate();
            var gcd = gcdSvc.CalculateGCDofTwoNumber(numberA, numberB);
            return (numberA * numberB) / gcd;
        }
    }
}
