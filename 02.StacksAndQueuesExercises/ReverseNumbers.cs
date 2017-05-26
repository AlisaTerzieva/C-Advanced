using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                nums.Push(input[i]);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
