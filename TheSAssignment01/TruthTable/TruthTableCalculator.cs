using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruthTable
{
    public class TruthTableCalculator
    {
        public IEnumerable<IEnumerable<string>> GetTruthTableAndResult(string operation, IEnumerable<string> stringSet)
        {
            var truthtable = GetTruthTable(stringSet);
            var truthtableAndResult = new List<List<string>> { };
            foreach (var item in truthtable)
            {
                List<string> rowAndResult = item.ToList();
                rowAndResult.Add(GetResult(operation, item));
                truthtableAndResult.Add(rowAndResult);
            }
            return truthtableAndResult;
        }

        public IEnumerable<IEnumerable<string>> GetTruthTable(IEnumerable<string> stringSet)
        {
            var truthtable = new List<List<string>> { };
            var pow = Convert.ToInt32(Math.Pow(2, stringSet.Count()));
            var loopRound = pow == 1 ? 2 : pow;
            for (int i = loopRound - 1; i >= 0; i--)
            {
                var currentRow = new List<string> { };
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

        public string DisplayTable(string operation, IEnumerable<IEnumerable<string>> truthtable, IEnumerable<string> stringSet)
        {
            var stringAndOperation = stringSet.ToList();
            stringAndOperation.Add(operation);

            StringBuilder sb = new StringBuilder();
            var line = "|";

            foreach (var header in stringAndOperation)
            {
                var Startspace = header.Length <= 2 ? 2 : 1;
                sb.Append($"{new string(' ', Startspace)}{header}{new string(' ', 1)}");
            };
            sb.Append(Environment.NewLine);
            foreach (var row in truthtable)
            {
                foreach (var item in row)
                {
                    sb.Append($"{line} {item}{new string(' ', 1)}");
                }
                sb.Append(line);
                sb.Append(Environment.NewLine);
            };
            return sb.ToString();
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
                        result = numberOfTrue % 2 == 0 ? "F" : "T";
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
