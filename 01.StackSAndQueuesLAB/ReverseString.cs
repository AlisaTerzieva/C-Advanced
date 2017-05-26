using System;
using System.Collections.Generic;

public class ReverseString
{
    public static void Main()
    {
        var input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        foreach (var item in input)
        {
            stack.Push(item);
        }
        int length = stack.Count;
        for(int i = 0; i < length; i++)
        {
            Console.Write(stack.Pop());
        }
        Console.WriteLine();
    }
}