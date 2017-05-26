using System;
using System.Collections.Generic;
public class DecimalToBinary
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        if (num != 0)
        {
            while (num / 2 > 0 || num == 1)
            {
                int remainder = num % 2;
                stack.Push(remainder);
                num /= 2;
            }
        }
        else
        {
            stack.Push(0);
        }
        Console.WriteLine(String.Join("", stack));
    }
}
