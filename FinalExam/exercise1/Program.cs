using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Translate")
                {
                    string c = tokens[1];
                    string replacement = tokens[2];

                    text = text.Replace(c, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    if (text.Contains(tokens[1])) Console.WriteLine("True");
                    else Console.WriteLine("False");
                }
                else if (command == "Start")
                {
                    if (text.IndexOf(tokens[1]) == 0) Console.WriteLine("True");
                    else Console.WriteLine("False");
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    int index = text.LastIndexOf(tokens[1]);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int si = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);
                    text = text.Remove(si, count);
                    Console.WriteLine(text);
                }
               
                input = Console.ReadLine();
            }

        }
    }
}