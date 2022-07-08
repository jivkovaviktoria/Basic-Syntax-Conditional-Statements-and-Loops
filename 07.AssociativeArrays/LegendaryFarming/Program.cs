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
            Dictionary<string, int> materials = new Dictionary<string, int>();
            List<string> materialsOrder = new List<string>();
            while (!HasLegendaryItem(materials))
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length && !HasLegendaryItem(materials); i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string materialName = input[i + 1].ToLower();

                    if (!materials.ContainsKey(materialName))
                    {
                        materials[materialName] = 0;
                        materialsOrder.Add(materialName);
                    }
                    materials[materialName] += quantity;
                }
            }

            DiscoverLegendaryItem(materials);

            HashSet<string> legendaryMaterialsSet = new HashSet<string>(_legendaryMaterials);
            PrintItems(materials, materialsOrder.Where(mo => legendaryMaterialsSet.Contains(mo)));
            PrintItems(materials, materialsOrder.Where(mo => !legendaryMaterialsSet.Contains(mo)));
        }

        private static readonly string[] _legendaryMaterials = new string[] { "shards", "motes", "fragments" };
        private static readonly string[] _legendaryItemNames = new string[] { "Shadowmourne", "Dragonwrath", "Valanyr" };

        private static bool HasLegendaryItem(Dictionary<string, int> materials)
        {
            for (int i = 0; i < 3; i++)
            {
                string currentLegendaryMaterial = _legendaryMaterials[i];
                if (materials.ContainsKey(currentLegendaryMaterial) && materials[currentLegendaryMaterial] >= 250)
                    return true;
            }

            return false;
        }

        private static void DiscoverLegendaryItem(Dictionary<string, int> materials)
        {
            for (int i = 0; i < 3; i++)
            {
                string currentLegendaryMaterial = _legendaryMaterials[i];
                if (materials.ContainsKey(currentLegendaryMaterial) && materials[currentLegendaryMaterial] >= 250)
                {
                    Console.WriteLine($"{_legendaryItemNames[i]} obtained!");
                    materials[currentLegendaryMaterial] -= 250;
                    return;
                }
            }
        }

        private static void PrintItems(Dictionary<string, int> materials, IEnumerable<string> materialsOrder)
        {
            foreach (string currentMaterial in materialsOrder)
            {
                if (materials.ContainsKey(currentMaterial))
                    Console.WriteLine($"{currentMaterial}: {materials[currentMaterial]}");
            }
        }
    }
}