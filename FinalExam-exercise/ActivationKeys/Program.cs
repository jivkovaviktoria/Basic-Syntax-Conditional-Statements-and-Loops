using System;
using System.Text;
namespace ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();
            while (input!="Generate")
            {
                string[] tokens = input.Split(">>>");
                string command = tokens[0];

                if(command == "Contains")
                {
                    string substring = tokens[1];
                    if (text.Contains(substring)) Console.WriteLine($"{text} contains {substring}");
                    else Console.WriteLine($"Substring not found!");
                }
                else if(command=="Flip")
                {
                    string upOrLow = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);

                    var substring = text.Substring(startIndex, endIndex-startIndex);
                    if (upOrLow == "Lower") text = text.Replace(substring, substring.ToLower());
                    else text = text.Replace(substring, substring.ToUpper());

                    Console.WriteLine(text);
                }
                else if(command=="Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    text = text.Remove(startIndex, endIndex-startIndex);
                    Console.WriteLine(text);
                }

                input = Console.ReadLine(); 
            }

            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}