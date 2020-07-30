using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruthTable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new TruthTableCalculator();
            var stringSet = new List<string> { };
            var operationSet = new List<string> { "and","or","xor" };
            var operation = string.Empty;
            var isCompleteNumber = false;
            var isCompleteOperation = false;
            Console.WriteLine("TRUTH TABLE GENERATOR");
            while (!isCompleteNumber)
            {
                Console.WriteLine("Please insert number of character: ");
                var inputIsNumber = int.TryParse(Console.ReadLine(), out var result);
                if (inputIsNumber && result > 0)
                {
                    char charString = 'a';
                    for (int i = 0; i < result; i++)
                    {
                        stringSet.Add(charString.ToString());
                        charString++;
                    }
                    isCompleteNumber = true;
                }
            }
            while (!isCompleteOperation)
            {
                Console.WriteLine("Please input operation 'and','or','xor':");
                var operationInput = Console.ReadLine();
                var isCorrect = operationSet.Contains(operationInput.ToLower());
                if (isCorrect)
                {
                    operation = operationInput;
                    isCompleteOperation = true;
                }
            }
            var truthTable = svc.GetTruthTableAndResult(operation, stringSet);
            Console.WriteLine(svc.DisplayTable(operation, truthTable, stringSet));
            Console.ReadKey();
        }
    }
}
