﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public class TruthTableCalculator
    {
        public IEnumerable<IEnumerable<string>> GetTruthTable(IEnumerable<string> stringSet)
        {
            List<List<string>> truthtable = new List<List<string>> { };
            var pow = Convert.ToInt32(Math.Pow(2, stringSet.Count()));
            var loopRound = pow == 1 ? 2 : pow;
            for (int i = loopRound - 1; i >= 0; i--)
            {
                List<string> currentRow = new List<string> { };
                string binary = Convert.ToString(i, 2);
                if (binary.Length != stringSet.Count())
                {
                    var loop = stringSet.Count() - binary.Length;
                    for (int x = 0; x < loop; x++)
                    {
                        binary = binary.Insert(0, "0");
                    }
                }
                foreach (char ch in binary.ToCharArray())
                {
                    if (ch == '0')
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

        public IEnumerable<IEnumerable<string>> GetTruthTableAndResult(string operation, IEnumerable<string> stringSet)
        {
            List<List<string>> truthtable = new List<List<string>> { };
            var pow = Convert.ToInt32(Math.Pow(2, stringSet.Count()));
            var loopRound = pow == 1 ? 2 : pow;
            for (int i = loopRound - 1; i >= 0; i--)
            {
                List<string> currentRow = new List<string> { };
                string binary = Convert.ToString(i, 2);
                if (binary.Length != stringSet.Count())
                {
                    var loop = stringSet.Count() - binary.Length;
                    for (int x = 0; x < loop; x++)
                    {
                        binary = binary.Insert(0, "0");
                    }
                }
                foreach (char ch in binary.ToCharArray())
                {
                    if (ch == '0')
                    {
                        currentRow.Add("F");
                    }
                    else
                    {
                        currentRow.Add("T");
                    }
                }
                currentRow.Add(GetResult(operation, currentRow));
                truthtable.Add(currentRow);
            }
            return truthtable;
        }

        private string GetResult(string operation, IEnumerable<string> truthtable)
        {
            var result = "F";
            switch (operation)
            {
                case "and":
                    result = truthtable.Contains("F") ? "F" : "T";
                    break;
                case "or":
                    result = truthtable.Contains("T") ? "T" : "F";
                    break;
                case "xor":
                    if (truthtable.Contains("T"))
                    {
                        var numberOfTrue = truthtable.Where((it) => it.Contains("T")).Count();
                        result = numberOfTrue % 2 == 0 ? "F": "T";
                    }
                    break;
                default:
                    result = "F";
                    break;
            }
            return result;
        }
    }
}
