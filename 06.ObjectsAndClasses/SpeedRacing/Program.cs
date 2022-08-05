using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string model = tokens[0];
                int fuelAmount = int.Parse(tokens[1]);
                double fuelConsumption = double.Parse(tokens[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split();
                string model = tokens[1];
                double distance = double.Parse(tokens[2]);

                Car currentCar = cars.Find(x => x.Model == model);
                currentCar.Drive(distance);

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Traveled}");
            }
        }
    }

    class Car
    {
        public Car(string model, int fuelAmount, double fuelConsumption)
        {
            Model = model;
            Fuel = fuelAmount;
            FuelConsumption = fuelConsumption;
            Traveled = 0;
        }

        public void Drive(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if(Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                Traveled += distance;
            }
            else Console.WriteLine($"Insufficient fuel for the drive");
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumption { get; set; }

        public double Traveled { get; set; } 
    }
}