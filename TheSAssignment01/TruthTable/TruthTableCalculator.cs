using System;
using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public class TruthTableCalculator
    {
        public IEnumerable<IEnumerable<string>> GetTruthTable(string stringOperation,IEnumerable<string> stringSet)
        {
            List<List<string>> truthtable = new List<List<string>> { };
            var loopRound = stringSet.ToList().Count()^2;
            for (int i = 0; i < loopRound; i++)
            {

            }
            return new List<List<string>>
                {
                    new List<string> {"T","T","T"},
                    new List<string> {"T","F","F"},
                    new List<string> {"F","T","F"},
                    new List<string> {"F","F","F"}
                };
        }
    }
}
