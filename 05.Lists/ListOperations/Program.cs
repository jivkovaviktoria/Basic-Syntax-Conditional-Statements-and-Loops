using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    integers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index < 0 || index >= integers.Count) Console.WriteLine("Invalid index");
                    else integers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index >= integers.Count) Console.WriteLine("Invalid index");
                    else integers.RemoveAt(index);
                }
                else if (tokens[1] == "left")
                {
                    int count = int.Parse(tokens[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int num = integers[0];
                        integers.RemoveAt(0);
                        integers.Add(num);
                    }
                }
                else if (tokens[1] == "right")
                {
                    int count = int.Parse(tokens[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int num = integers[integers.Count - 1];
                        integers.RemoveAt(integers.Count - 1);
                        integers.Insert(0, num);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}