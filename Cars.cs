using System;

namespace ClassIntro
{
    class Car
    {
        // Fields
        // These are similar to properties but they are typ private and do not specify getters and setters
        private string _vinNumber;
        // Constructor
        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 1_000_000).ToString();
        }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Mileage { get; private set; }
        public string Color { get; set; }
        public string CourntryOfOrigin { get; set; }
        public bool IsInsepected { get; set; }
        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        public void Drive(int milesDriven)
        {
            // there is a this. implied before Mileage
            Mileage += milesDriven;
        }

        public void Drive()
        {
            Mileage += 5;
        }
    }
}