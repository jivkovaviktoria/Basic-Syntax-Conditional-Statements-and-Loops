using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> coffees = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Include")
                    coffees.Add(tokens[1]);


                else if (command == "Reverse")
                    coffees.Reverse();

                else if (command == "Prefer")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    if (index1 >= 0 && index1 <= coffees.Count - 1 && index2 >= 0 && index2 <= coffees.Count - 1)
                    {
                        string tmp = coffees[index1];
                        coffees[index1] = coffees[index2];
                        coffees[index2] = tmp;
                    }
                }
                else if (command == "Remove")
                {
                    string firstOrLast = tokens[1];
                    int count = int.Parse(tokens[2]);

                    if (count <= coffees.Count)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            if (firstOrLast == "first") coffees.RemoveAt(0);
                            else if (firstOrLast == "last") coffees.RemoveAt(coffees.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }
    }
}
