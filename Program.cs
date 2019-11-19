using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();
            Car ford = new Car("Ford", "Bronco", 80_000);
            ford.Year = 1986;
            ford.Color = "Pearl";
            ford.IsInsepected = true;
            ford.CourntryOfOrigin = "America";

            Car toyota = new Car("Toyota", "4Runner", 300)
            {
                Year = 2019,
                Color = "Black",
                IsInsepected = false,
                CourntryOfOrigin = "Japan"
            };
            Car chevy = new Car("Chevy", "Malibu", 300_000)
            {
                Year = 1995,
                Color = "Red",
                IsInsepected = false,
                CourntryOfOrigin = "America"
            };

            carLot.Add(ford);
            carLot.Add(toyota);

            Console.WriteLine($"The Ford has {ford.Mileage} miles");
            ford.Drive(10);
            Console.WriteLine($"The Ford has driven {ford.Mileage}");
            Console.WriteLine(ford.Description);
            Console.WriteLine(chevy.Description);
            Console.WriteLine(toyota.Description);
            toyota.Drive(3000);
            Console.WriteLine(toyota.Description);

            Console.WriteLine(chevy.Mileage);
            chevy.Drive(100_000);
            Console.WriteLine(chevy.Mileage);

        }
    }
}