using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input!="Craft!")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string item = tokens[1];
                switch (command)
                {
                    case "Collect":
                        if (!items.Contains(item))
                            items.Add(item);
                        break;
                    case "Drop":
                        if (items.Contains(item))
                            items.Remove(item);
                        break;
                    case "Combine Items":
                        string[] itemsToCombine = tokens[1].Split(':');
                        string oldItem = itemsToCombine[0];
                        string newItem = itemsToCombine[1];

                        int index = items.IndexOf(oldItem);
                        if (items.Contains(oldItem))
                        {
                            items.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
