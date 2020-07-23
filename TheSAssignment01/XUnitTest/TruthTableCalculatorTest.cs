using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTest
{
    public class TruthTableCalculatorTest
    {
        public static IEnumerable<object[]> posibilityTruthTable = new List<object[]>
        {
            new object[]
            {
                "and",
                new List<string>{"a,b"},
                new List<List<string>>
                {
                    new List<string> {"T","T","T"},
                    new List<string> {"T","F","F"},
                    new List<string> {"F","T","F"},
                    new List<string> {"F","F","F"}

                }
            }
        };
        [MemberData(nameof(posibilityTruthTable))]
        [Theory]
        public void CalculateAndOperation(string operationstring, IEnumerable<string> stringSet, IEnumerable<IEnumerable<string>> expected)
        {
            var sut = new TruthTable.TruthTableCalculator();
            var actual = sut.GetTruthTable(operationstring,stringSet.ToArray());
            Assert.Equal(expected, actual);
        }
    }
}
