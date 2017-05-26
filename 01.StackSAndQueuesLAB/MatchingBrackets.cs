using System;
using System.Collections.Generic;
public class MatchingBrackets
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push(i);
            }
            else if (input[i] == ')')
            {
                int currentIndex = i;
                int startIndex = stack.Pop();
                Console.WriteLine(input.Substring(startIndex, currentIndex - startIndex + 1));
            }
        }
    }
}