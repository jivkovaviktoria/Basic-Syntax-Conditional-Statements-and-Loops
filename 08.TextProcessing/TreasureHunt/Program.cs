using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input!="find")
            {
                StringBuilder decrypted = new StringBuilder();
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (index == keys.Length) index = 0;
                    int key = keys[index];

                    decrypted.Append((char)(input[i]-key));
                    index++;
                }

                string decryptedText = decrypted.ToString();

                Match type = Regex.Match(decryptedText, @"&(?<type>[\w]+)&");
                Match coordinates = Regex.Match(decryptedText, @"<(?<coo>[\w]+)>");

                Console.WriteLine($"Found {type.Groups["type"].Value} at {coordinates.Groups["coo"].Value}");

                input = Console.ReadLine();
            }

            
        }
    }
}
