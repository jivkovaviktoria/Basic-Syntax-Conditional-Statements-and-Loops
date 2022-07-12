using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var emojiPattern = @"(?<separator>::|\*\*)(?<emoji>[A-Z][a-z]{2,})(\k<separator>)";
            var digitsPattern = @"\d";

            List<string> validEmojis = new List<string>();

            string text = Console.ReadLine();

            MatchCollection digits = Regex.Matches(text, digitsPattern);

            BigInteger coolThreshold = 1;

            foreach (Match digit in digits)
                coolThreshold *= int.Parse(digit.Value);

            MatchCollection emojis = Regex.Matches(text, emojiPattern);

            foreach (Match emoji in emojis)
            {
                int emojiCool = 0;

                foreach (char symbol in emoji.Groups["emoji"].Value)
                    emojiCool += (int)symbol;
                
                if (emojiCool >= coolThreshold)
                    validEmojis.Add(emoji.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in validEmojis)
                Console.WriteLine(emoji);
        }
    }
}
