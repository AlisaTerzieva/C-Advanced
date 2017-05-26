using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AcademyGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            SortedDictionary<string, double> studentsList = new SortedDictionary<string, double>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double[] grades = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                double averageScore = grades.Average();
                studentsList.Add(studentName, averageScore);
            }

            foreach (var kvp in studentsList)
            {
                Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value}");
            }
        }
    }
}
