using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogueVehicle = new Catalogue();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                string[] tokens = input.Split('/');
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int parameter = int.Parse(tokens[3]);

               

                if (type == "Car")
                {
                    catalogueVehicle.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HP = parameter
                    });
                }
                else if (type == "Truck")
                {
                    catalogueVehicle.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = parameter
                    });
                }
            }

            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car carList in catalogueVehicle.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HP}hp");
                }
            }

            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truckList in catalogueVehicle.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }

    class Truck
    {

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HP { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
