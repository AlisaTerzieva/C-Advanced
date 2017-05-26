using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mySortedDictionary = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var nextLine = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in nextLine)
                {
                    if (!mySortedDictionary.Contains(item))
                    {
                        mySortedDictionary.Add(item);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", mySortedDictionary));
        }
    }
}
