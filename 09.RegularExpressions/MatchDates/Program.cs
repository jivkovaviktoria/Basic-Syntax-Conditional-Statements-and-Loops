using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([\.\/\-])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
            var dates = Console.ReadLine();

            var mathedDates = Regex.Matches(dates, pattern);

            foreach (Match date in mathedDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
