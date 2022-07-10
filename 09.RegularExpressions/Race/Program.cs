using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();

            Dictionary<string, int> racers = new Dictionary<string, int>();

            for (int i = 0; i < names.Length; i++)
                racers.Add(names[i], 0);

            string info = Console.ReadLine();

            while (info != "end of race")
            {
                string pattern = @"(?<name>[A-Za-z]+)|(?<distance>\d)";

                MatchCollection nameDistance = Regex.Matches(info, pattern);

                string name = "";
                int splitDigits = 0;

                foreach (Match item in nameDistance)
                {
                    foreach (var letter in item.Groups["name"].Value)
                        name += letter;

                    foreach (var digit in item.Groups["distance"].Value)
                        splitDigits += int.Parse(item.Groups["distance"].Value);
                }

                if (racers.ContainsKey(name))
                    racers[name] += splitDigits;


                info = Console.ReadLine();
            }

            int counter = 1;

            foreach (var racer in racers.OrderByDescending(x => x.Value).Take(3))
            {
                string place = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";

                Console.WriteLine($"{counter}{place} place: {racer.Key}");

                counter++;
            }

        }
    }
}