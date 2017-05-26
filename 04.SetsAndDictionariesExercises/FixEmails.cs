using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = Console.ReadLine();
            string[] deprecatedDomains = { "us", "uk" };
            Dictionary<string, string> personDetails = new Dictionary<string, string>();

            while (personName.ToLower() != "stop")
            {
                string personEmail = Console.ReadLine();
                int domainIndex = personEmail.LastIndexOf('.');
                string domain = personEmail.Substring(domainIndex + 1);

                if (!deprecatedDomains.Contains(domain))
                {
                    personDetails.Add(personName, personEmail);
                }

                personName = Console.ReadLine();
            }

            foreach (var kvp in personDetails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
