using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dict[Console.ReadLine()] = 1;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
