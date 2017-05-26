using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> parkedCars = new SortedSet<string>();

            string[] nextCar = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            while (nextCar[0] != "END")
            {
                string direction = nextCar[0];
                string number = nextCar[1];
                if (direction == "IN")
                {
                    parkedCars.Add(number);
                }
                else
                {
                    parkedCars.Remove(number);
                }

                nextCar = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (parkedCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkedCars)
                {
                    Console.WriteLine(car.TrimStart());
                }
            }
        }
    }
}
