using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(=|\/)(?<place>[A-Z][A-za-z]{2,})\1";
            List<string> places = new List<string>();

            string text = Console.ReadLine();

            MatchCollection destinations = Regex.Matches(text, pattern);
            var travelPoints = 0;

            foreach (Match destination in destinations)
            {
                places.Add(destination.Groups["place"].Value);
                travelPoints += destination.Groups["place"].Value.Length;
            }

            Console.WriteLine($"Destinations: { string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
