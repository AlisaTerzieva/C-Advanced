using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
 
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            foreach (double number in numbersInput)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number]++;
                }
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
