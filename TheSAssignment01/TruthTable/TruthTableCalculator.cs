using System;
using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public class TruthTableCalculator
    {
        public IEnumerable<IEnumerable<string>> GetTruthTable(IEnumerable<string> stringSet)
        {
            List<List<string>> truthtable = new List<List<string>> { };
            var pow = Convert.ToInt32(Math.Pow(stringSet.Count(),2));
            var loopRound = pow == 1 ? 2 : pow;
            for (int i = loopRound - 1; i >= 0; i--)
            {
                List<string> currentRow = new List<string> { };
                string binary = Convert.ToString(i, 2);
                if(binary.Length == 1)
                {
                    binary = binary.Insert(0, "0");
                }
                foreach (char ch in binary.ToCharArray())
                {
                    if(ch == '0')
                    {
                        currentRow.Add("F");
                    }
                    else
                    {
                        currentRow.Add("T");
                    }
                }
                truthtable.Add(currentRow);
            }
            return truthtable;
        }
    }
}
