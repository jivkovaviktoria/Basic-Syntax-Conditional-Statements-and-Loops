using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([@|#]+)(?<egg>[a-z]{3,})([@|#]+)([^A-Za-z0-9]*)(\/+)(?<amount>[0-9]+)(\/+)";
            string input = Console.ReadLine();

            MatchCollection eggsFound = Regex.Matches(input, pattern);

            foreach (Match item in eggsFound)
            {
                var color = item.Groups["egg"];
                var count = item.Groups["amount"];
                Console.WriteLine($"You found {count} {color} eggs!");
            }
        }
    }
}