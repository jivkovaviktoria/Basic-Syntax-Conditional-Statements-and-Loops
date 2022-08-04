using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input!="End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int hp = int.Parse(tokens[3]);

                if(type == "Car")
                {
                    Car newCar = new Car(type, model, color, hp);
                }

                input = Console.ReadLine();
            }

        }
    }

    class Truck
    {
        public Truck(string type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hp;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }

    class Car
    {
        public Car(string type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hp;


        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }

    class Catalogue
    {
        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }

        public List<int> carsHP { get; set; }
        public List<int> trucksHP { get; set; }
    }
}
