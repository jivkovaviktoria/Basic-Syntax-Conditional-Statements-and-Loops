using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');
                var model = carInfo[0];
                var mileage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);

                cars.Add(model, new List<int>());
                cars[model].Add(mileage);
                cars[model].Add(fuel);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] tokens = input.Split(" : ");
                string command = tokens[0];
                string car = tokens[1];
                if (command == "Drive")
                {
                    var distance = int.Parse(tokens[2]);
                    var fuel = int.Parse(tokens[3]);
                    if (cars[car][1] >= fuel)
                    {
                        cars[car][1] -= fuel;
                        cars[car][0] += distance;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else Console.WriteLine("Not enough fuel to make that ride");

                    if (cars[car][0] > 100000)
                    {
                        cars.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    var fuel = int.Parse(tokens[2]);

                    if (cars[car][1] + fuel > 75)

                    {
                        Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");
                        cars[car][1] = 75;

                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if(command=="Revert")
                {
                    var km = int.Parse(tokens[2]);

                    if (cars[car][0] - km < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        cars[car][0] -= km;
                        Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                var carModel = car.Key;
                var mileage = car.Value[0];
                var fuel = car.Value[1];

                Console.WriteLine($"{carModel} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
