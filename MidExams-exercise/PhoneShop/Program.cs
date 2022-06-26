using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];

                if (command == "Add" && !phones.Contains(tokens[1]))
                    phones.Add(tokens[1]);

                else if (command == "Remove" && phones.Contains(tokens[1]))
                    phones.Remove(tokens[1]);

                else if (command == "Last" && phones.Contains(tokens[1]))
                {
                    int index = phones.IndexOf(tokens[1]);
                    string phone = phones[index];
                    phones.RemoveAt(index);
                    phones.Add(phone);
                }
                else if (command == "Bonus phone")
                {
                    string[] phonesToInsert = tokens[1].Split(":");
                    if (phones.Contains(phonesToInsert[0]))
                    {
                        int index = phones.IndexOf(phonesToInsert[0]);
                        phones.Insert(index + 1, phonesToInsert[1]);
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
