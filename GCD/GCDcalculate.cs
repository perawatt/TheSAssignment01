using System;

namespace GCD
{
    public class GCDcalculate : IGCDcalculate
    {
        //public long getGCDofTwoNumber(long numberA, long numberB)
        //{
        //    throw new NotImplementedException();
        //}

        public long getGCDofTwoNumber(long numberA, long numberB)
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
