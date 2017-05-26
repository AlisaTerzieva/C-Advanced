using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            bool isSearchActive = false;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while(command != "stop")
            {
                if(command == "search")
                {
                    isSearchActive = true;
                }
                if (!isSearchActive && command != "search")
                {
                    string[] personDetails = command.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string personName = personDetails[0];
                    string personNumber = personDetails[1];
                    if (!phoneBook.ContainsKey(personName))
                    {
                        phoneBook.Add(personName, personNumber);
                    }
                    else
                    {
                        phoneBook[personName] = personNumber;
                    }
                }
                else if(command != "search")
                {
                    string nextPerson = command;
                    if (phoneBook.ContainsKey(nextPerson))
                    {
                        Console.WriteLine($"{nextPerson} -> {phoneBook[nextPerson]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {nextPerson} does not exist.");
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}
