using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int N = inputArgs[0];
            int S = inputArgs[1];
            int X = inputArgs[2];

            Stack<int> nums = new Stack<int>();

            int[] inputNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var num in inputNums)
            {
                nums.Push(num);
            }

            // What if S is higher than nums.Count?
            for (int i = 0; i < S; i++)
            {
                nums.Pop();
            }

            Console.WriteLine(nums.Contains(X) ? "true" : nums.Count > 0 ? nums.Min().ToString() : "0");
        }
    }
}
