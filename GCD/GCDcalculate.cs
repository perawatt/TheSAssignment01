using System;

namespace GCD
{
    public class GCDcalculate : IGCDcalculate
    {
        public long calculateGCDofTwoNumber(long numberA, long numberB)
        {
            while (numberA != 0 && numberB != 0)
            {
                if (numberA > numberB)
                    numberA %= numberB;
                else
                    numberB %= numberA;
            }

            return numberA == 0 ? numberB : numberA;
        }
    }
}
