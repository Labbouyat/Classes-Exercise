using System;
using System.Collections.Generic;

namespace Classes_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Explorer";
            ford.Year = 2011;

            var hyundai = new Car("Hyundai", "Sonata", 2011);

            var chrysler = new Car()
            {
                Make = "Chrysler",
                Model = "200 LX FWD",
                Year = 2016
            };

            var carList = new List<Car>() { ford, chrysler, hyundai };

            foreach (var car in carList)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
            }
        }
    }
}
