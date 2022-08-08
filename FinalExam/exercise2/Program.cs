using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> meals = new Dictionary<string, List<string>>();
            int unliked = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] tokens = input.Split('-');
                string command = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];

                if(command == "Like")
                {
                    if(!meals.ContainsKey(guest))
                    {
                        meals.Add(guest, new List<string>());
                        meals[guest].Add(meal);
                    }
                    else if (meals.ContainsKey(guest))
                    {
                        if (!meals[guest].Contains(meal)) meals[guest].Add(meal);
                    }
                }
                else if(command == "Dislike")
                {
                    if (!meals.ContainsKey(guest))
                        Console.WriteLine($"{guest} is not at the party.");
                    else if (meals.ContainsKey(guest))
                    {
                        if (!meals[guest].Contains(meal)) Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        else
                        {
                            meals[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unliked++;
                        }
                    }       
                }

                input = Console.ReadLine();
            }

            foreach (var item in meals)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}