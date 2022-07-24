using System;
using System.Linq;
using System.Text;

namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tokens = input.Split(":|:");
                string command = tokens[0];

                if (command == "InsertSpace")
                {
                    text = InsertSpace(text, tokens);
                    Console.WriteLine(text);
                }
                else if (command == "Reverse")
                {
                    var result = Reverse(text, tokens);
                    if (result != "error")
                        text = Reverse(text, tokens);
                    Console.WriteLine(result);
                }
                else if (command == "ChangeAll")
                {
                    text = ChangeAll(text, tokens);
                    Console.WriteLine(ChangeAll(text, tokens));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {text}");
        }

        static string Reverse(string text, string[] tokens)
        {
            string error = "error";
            string substring = tokens[1];
            int startIndex = text.IndexOf(substring);
            if (startIndex != -1)
            {
                text = text.Remove(startIndex, substring.Length);

                var reversedString = string.Empty;

                for (int i = 0; i <= substring.Length - 1; i++)
                    reversedString += substring[substring.Length - 1 - i];


                text = text.Insert(text.Length, reversedString);
                return text;
            }
            else return error;
        }

        static string ChangeAll(string text, string[] tokens)
        {
            string oldString = tokens[1];
            string replacement = tokens[2];

            text = text.Replace(oldString, replacement);
            return text;
        }
        static string InsertSpace(string text, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            text = text.Insert(index, " ");
            return text;
        }
    }
}