using System;
using System.Collections.Generic;

namespace GCD.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new GCDcalculate();
            List<long> numbers = new List<long>();
            Console.WriteLine("Greatest common divisor");
            Console.WriteLine("Please insert two numbers:");
            while (numbers.Count < 2)
            {
                if (numbers.Count == 0)
                {
                    Console.Write("First number :");
                }
                else
                {
                    Console.Write("Second number :");
                }
                var input = Console.ReadLine();
                var isLong = long.TryParse(input, out long longInput);
                if (isLong && longInput > 0)
                {
                    numbers.Add(longInput);
                }
                else
                {
                    Console.WriteLine("Wrong input !");
                }
            }
            var result = svc.getGCDofTwoNumber(numbers[0], numbers[1]);
            Console.WriteLine($"Greatest common divisor of {numbers[0]} and {numbers[1]} is : {result}");
            Console.ReadKey();
        }
    }
}
