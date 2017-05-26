using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> nums = new Stack<int>();
            Stack<int> maxNums = new Stack<int>();

            int maxNum = int.MinValue;
            maxNums.Push(maxNum);
            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        {
                            int currentNum = command[1];
                            nums.Push(currentNum);
                            if(currentNum > maxNum)
                            {
                                maxNum = currentNum;
                                maxNums.Push(maxNum);
                            }
                            
                        }  break;
                    case 2:
                        {
                            int currentNum = nums.Peek();
                            if (currentNum == maxNum)
                            {
                                maxNums.Pop();
                                maxNum = maxNums.Peek();
                            }
                                nums.Pop();
                        } break;
                    case 3: Console.WriteLine(maxNums.Peek()); break;
                    default: break;
                }
            }
        }
    }
}
