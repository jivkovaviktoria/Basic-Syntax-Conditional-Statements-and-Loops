using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split("<->");
                string plant = data[0];
                string rarity = data[1];

                if (!plants.ContainsKey(plant)) plants[plant] = new Plant();
                plants[plant].Rarity = rarity;
            }

            string input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] tokens = input.Split(": ");
                string command = tokens[0];

                string[] arguments = tokens[1].Split(" - ");
                string plantName = arguments[0];
                if (!plants.ContainsKey(plantName)) Console.WriteLine("error");
                else
                {
                    if (command == "Rate")
                    {
                        int newRating = int.Parse(arguments[1]);
                        plants[plantName].Ratings.Add(newRating);
                    }
                    else if (command == "Update")
                    {
                        string newRarity = arguments[1];
                        plants[plantName].Rarity = newRarity;
                    }
                    else if (command == "Reset")
                    {
                        plants[plantName].Ratings.Clear();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var (plantName, plant) in plants)
            {
                double averageRating = 0;
                if (plant.Ratings.Count > 0) averageRating = plant.Ratings.Average();
                Console.WriteLine($"- {plantName}; Rarity: {plant.Rarity}; Rating: {averageRating:F2}");
            }
        }
    }

    class Plant
    {
        public string Rarity { get; set; }
        public List<int> Ratings { get; } = new List<int>();
    }
}
