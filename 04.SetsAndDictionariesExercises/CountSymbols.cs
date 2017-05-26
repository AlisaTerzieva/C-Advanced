using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            foreach (var character in inputText)
            {
                if (!symbolsCount.ContainsKey(character))
                {
                    symbolsCount.Add(character, 1);
                }
                else
                {
                    symbolsCount[character]++;
                }
            }

            foreach (var kvp in symbolsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
