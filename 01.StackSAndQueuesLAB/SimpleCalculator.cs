using System;
using System.Collections.Generic;

public class SimpleCalculator
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(input);
        Stack<string> stack = new Stack<string>(input);
        
        while(stack.Count > 1)
        {
            int prevNum = int.Parse(stack.Pop());
            string operand = stack.Pop();
            int nextNum = int.Parse(stack.Pop());
            int result = 0;
            switch (operand)
            {
                case "+": result = prevNum + nextNum; break;
                case "-": result = prevNum - nextNum; break;
            }
            stack.Push(result.ToString());            
        }
        Console.WriteLine(stack.Peek());
    }
}

