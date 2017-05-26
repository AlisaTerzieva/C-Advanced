using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>(input);

        while(queue.Count > 1)
        {
            for (int i = 0; i < count; i++)
            {
                string currentPerson = queue.Dequeue();
                if (i == count - 1)
                {
                    Console.WriteLine($"Removed {currentPerson}");
                }
                else
                {
                    queue.Enqueue(currentPerson);
                }
            }
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}