using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = nm[0];
            int m = nm[1];

            HashSet<int> hashSetN = new HashSet<int>();
            HashSet<int> hashSetM = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                hashSetN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                hashSetM.Add(int.Parse(Console.ReadLine()));
            }

            var repeatingValues = hashSetN.Intersect(hashSetM).ToArray();

            Console.WriteLine(String.Join(" ", repeatingValues));
        }
    }
}
