using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AMinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string ore = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (ore.ToLower() != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(ore))
                {
                    resources.Add(ore, quantity);
                }
                else
                {
                    resources[ore] += quantity;
                }
                ore = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
