using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> chests = Console.ReadLine().Split('|').ToList();

            string input = Console.ReadLine();



            while (true)
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];

                if (input == "Yohoho!") break;

                if (command == "Loot")
                {
                    string item = "";
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        item = tokens[i];
                        if (!chests.Contains(item)) chests.Insert(0, item);
                    }

                }
                else if (command == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < chests.Count)
                    {
                        string item = chests[index];
                        chests.RemoveAt(index);
                        chests.Add(item);
                    }
                }
                else if (command == "Steal")
                {
                    List<string> steal = new List<string>();
                    int count = int.Parse(tokens[1]);
                    count = Math.Min(chests.Count, count);

                    for (int i = chests.Count - count; i < chests.Count; i++)
                    {
                        steal.Add(chests[i]);
                    }
                    Console.WriteLine(string.Join(", ", steal));

                    chests.RemoveRange(chests.Count - count, count);
                }
                input = Console.ReadLine();
            }

            int lengthOfItem = 0;
            double sum = 0;
            for (int i = 0; i < chests.Count; i++)
            {
                lengthOfItem = chests[i].Length;
                sum += lengthOfItem;
            }
            if (chests.Count > 0)
                Console.WriteLine($"Average treasure gain: {(sum / chests.Count):f2} pirate credits.");
            else
                Console.WriteLine("Failed treasure hunt.");

        }
    }
}
