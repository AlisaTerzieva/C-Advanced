using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            Stack<long> fibStack = new Stack<long>();
            fibStack.Push(1);
            fibStack.Push(1);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                long a = fibStack.Pop();
                long b = fibStack.Pop();
                long res = a + b;
                fibStack.Push(res);
                fibStack.Push(b);
            }

            Console.WriteLine(fibStack.Peek());
        }
    }
}
