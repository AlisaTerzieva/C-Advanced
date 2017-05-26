using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    public class Startup
    {
        public static void Main()
        {
            int[] inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] inpNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int n = inputArgs[0];
            int s = inputArgs[1];
            int x = inputArgs[2];

            int smallestNum = int.MaxValue;

            bool hasX = false;

            Queue<int> nums = new Queue<int>();

            foreach (int num in inpNums)
            {
                nums.Enqueue(num);
            }

            for (int i = 0; i < s; i++)
            {
                nums.Dequeue();
            }

            while (nums.Count > 0)
            {                
                if (nums.Peek() == x)
                {
                    hasX = true;
                    Console.WriteLine("true");
                    break;
                }
                if (nums.Peek() < smallestNum)
                {
                    smallestNum = nums.Peek();                    
                }
                nums.Dequeue();
            }
            if (!hasX)
            {
                Console.WriteLine(smallestNum != int.MaxValue ? smallestNum : 0);
            }
        }
    }
}
