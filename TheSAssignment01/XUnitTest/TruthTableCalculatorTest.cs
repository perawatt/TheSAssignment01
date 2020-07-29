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

        //public static IEnumerable<object[]> generateTruthTable = new List<object[]>
        //{
        //    new object[]
        //    {
        //        new List<string>{"a"},
        //        new List<List<string>>
        //        {
        //            new List<string> {"T"},
        //            new List<string> {"F"},

        //        }
        //    },
        //    new object[]
        //    {
        //        new List<string>{"a","b"},
        //        new List<List<string>>
        //        {
        //            new List<string> {"T","T"},
        //            new List<string> {"T","F"},
        //            new List<string> {"F","T"},
        //            new List<string> {"F","F"}

        //        }
        //    },
        //    new object[]
        //    {
        //        new List<string>{"a","b","c"},
        //        new List<List<string>>
        //        {
        //            new List<string> {"T","T","T"},
        //            new List<string> {"T","T","F"},
        //            new List<string> {"T","F","T"},
        //            new List<string> {"T","F","F"},
        //            new List<string> {"F","T","T"},
        //            new List<string> {"F","T","F"},
        //            new List<string> {"F","F","T"},
        //            new List<string> {"F","F","F"},
        //        }
        //    }
        //};

        //[MemberData(nameof(generateTruthTable))]
        //[Theory]
        //public void CalculateTruthTable(IEnumerable<string> stringSet, IEnumerable<IEnumerable<string>> expected)
        //{
        //    var sut = new TruthTable.TruthTableCalculator();
        //    var actual = sut.GetTruthTable(stringSet);
        //    actual.Should().BeEquivalentTo(expected);
        //}

        public static IEnumerable<object[]> posibilityTruthTable = new List<object[]>
        {
            new object[]
            {
                "and",
                new List<string>{"a","b"},
                new List<List<string>>
                {
                    new List<string> {"T","T","T"},
                    new List<string> {"T","F","F"},
                    new List<string> {"F","T","F"},
                    new List<string> {"F","F","F"}

                }
            },
            new object[]
            {
                "or",
                new List<string>{"a","b"},
                new List<List<string>>
                {
                    new List<string> {"T","T","T"},
                    new List<string> {"T","F","T"},
                    new List<string> {"F","T","T"},
                    new List<string> {"F","F","F"}

                }
            },
            new object[]
            {
                "xor",
                new List<string>{"a","b"},
                new List<List<string>>
                {
                    new List<string> {"T","T","F"},
                    new List<string> {"T","F","T"},
                    new List<string> {"F","T","T"},
                    new List<string> {"F","F","F"}

                }
            },
            //new object[]
            //{
            //    "xor",
            //    new List<string>{"a","b","c"},
            //    new List<List<string>>
            //    {
            //        new List<string> {"T","T","T","T"},
            //        new List<string> {"T","T","F","F"},
            //        new List<string> {"T","F","T","F"},
            //        new List<string> {"T","F","F","T"},
            //        new List<string> {"F","T","T","F"},
            //        new List<string> {"F","T","F","T"},
            //        new List<string> {"F","F","T","T"},
            //        new List<string> {"F","F","F","F"},
            //    }
            //}
        };
        [MemberData(nameof(posibilityTruthTable))]
        [Theory]
        public void CalculateAndOperation(string operationstring, IEnumerable<string> stringSet, IEnumerable<IEnumerable<string>> expected)
        {
            var sut = new TruthTable.TruthTableCalculator();
            var actual = sut.GetTruthTableAndResult(operationstring, stringSet);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
