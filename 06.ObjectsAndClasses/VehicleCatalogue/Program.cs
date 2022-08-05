using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int hp = int.Parse(tokens[3]);

                Vehicle newCar = new Vehicle(type, model, color, hp);
                vehicles.Add(newCar);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                Vehicle vehicle = vehicles.Find(x => x.Model == input);

                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.HP}");

                input = Console.ReadLine();
            }

            List<int> carsHP = new List<int>();
            List<int >trucksHP = new List<int>();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == "Car") carsHP.Add(vehicle.HP);
                
                else if (vehicle.Type == "Truck") trucksHP.Add(vehicle.HP);
            }

            if(carsHP.Count > 0) Console.WriteLine($"Cars have average horsepower of: {carsHP.Average():f2}.");
            else Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            if(trucksHP.Count > 0) Console.WriteLine($"Trucks have average horsepower of: {trucksHP.Average():F2}.");
            else Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int hp)
        {
            if (type == "car") Type = "Car";
            else Type = "Truck";

            Model = model;
            Color = color;
            HP = hp;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }

}
