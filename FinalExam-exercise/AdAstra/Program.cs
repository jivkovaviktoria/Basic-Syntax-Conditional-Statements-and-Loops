using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<separator>\||#)(?<name>[A-Za-z\s]+)(\k<separator>)(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\k<separator>)(?<calories>\d+)(\k<separator>)";
            var text = Console.ReadLine();
            var totalCalories = 0;

            MatchCollection foods = Regex.Matches(text, pattern);

            foreach (Match food in foods)
            {
                var calories = int.Parse(food.Groups["calories"].Value);
                totalCalories += calories;
            }

            var days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in foods)
            {
                var product = food.Groups["name"].Value;
                var date = food.Groups["date"].Value;
                var calories = food.Groups["calories"].Value;

                Console.WriteLine($"Item: {product}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}