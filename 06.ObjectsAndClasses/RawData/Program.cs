using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
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
                int speed = int.Parse(tokens[1]), power = int.Parse(tokens[2]), weight = int.Parse(tokens[3]);
                string type = tokens[4];

                Car car = new Car(model, speed, power, weight, type);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            foreach (Car car in cars)
            {
                if (command == "fragile" && car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000) Console.WriteLine(car.Model);
                else if (command == "flamable" && car.Cargo.Type == "flamable" && car.Engine.Power > 250) Console.WriteLine(car.Model);
            }
            
        }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Engine engine = new Engine(speed, power);
            Cargo cargo = new Cargo(weight, type);

            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    class Engine 
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }

        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
        public int Weight { get; set; }

        public string Type { get; set; }
    }

}