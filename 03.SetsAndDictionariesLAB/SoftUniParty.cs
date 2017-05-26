using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> vipGuestList = new HashSet<string>();
            SortedSet<string> normalGuestList = new SortedSet<string>();
            bool listNotFinished = true;
            while (command != "END")
            {                
                string nextGuest = command;

                if (command == "PARTY")
                {
                    listNotFinished = false;
                }
                if(listNotFinished)
                {                    
                    string invitation = "";
                    if (Char.IsLetter(nextGuest[0]))
                    {
                        normalGuestList.Add(nextGuest);
                    }
                    else
                    {
                        vipGuestList.Add(nextGuest);
                    }
                }
                else
                {
                    if (Char.IsLetter(nextGuest[0]))
                    {
                        normalGuestList.Remove(nextGuest);
                    }
                    else
                    {
                        vipGuestList.Remove(nextGuest);
                    }
                }

                command = Console.ReadLine();
            }
            normalGuestList.UnionWith(vipGuestList);
            Console.WriteLine(normalGuestList.Count);
            Console.WriteLine(String.Join("\n", normalGuestList));
        }
    }
}
