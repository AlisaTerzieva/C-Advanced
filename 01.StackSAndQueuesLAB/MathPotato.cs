using System;
using System.Collections.Generic;
public class MathPotato
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = int.Parse(Console.ReadLine());

        int cycle = 1;

        Queue<string> queue = new Queue<string>(input);

        while(queue.Count > 1)
        {
            for (int i = 0; i < count-1; i++)
            {
                string currentPerson = queue.Dequeue();
                queue.Enqueue(currentPerson);                
            }
            if (isPrime(cycle))
            {
                string current = queue.Peek();
                Console.WriteLine($"Prime {current}");
            }
            else
            {
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            cycle++;
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
    public static bool isPrime(int index)
    {
        if (index == 1) return false;
        if (index == 2) return true;

        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(index)); ++i)
        {
            if (index % i == 0) return false;
        }

        return true;
    }
}


