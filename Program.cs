using System;
using System.Collections.Generic;

namespace randomnumber
{
    class Program
    {
        static List<string> cars = new List<string> { "Audi", "Mazda", "toyota", "Nissan" };

        static List<string> drivers = new List<string> { "Bob", "Lisa", "Tim", "Simon", "Kevin" };
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
        }

        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }

        static string DisplayDriver()
        {

            var selectedCar = cars[GenerateRandomNumber(cars)];
            var selectedDriver = drivers[GenerateRandomNumber(drivers)];

            //Below are two different ways of displaying the random number

            //Return $"{selectedDriver} is driving the {selectedCar}';
            return $"Selected Driver = {selectedDriver}/nSelected Car = {selectedCar}";
        }

    }
}