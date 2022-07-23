using System;
using System.Text;

namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            StringBuilder sb = new StringBuilder(destinations);

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] tokens = input.Split(':');
                string command = tokens[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string stop = tokens[2];

                        if (index >= 0 && index < sb.Length)
                            sb.Insert(index, stop);
                        Console.WriteLine(sb);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (startIndex >= 0 && endIndex < sb.Length)
                            sb.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(sb);
                        break;
                    case "Switch":
                        string oldString = tokens[1];
                        string newString = tokens[2];

                        sb.Replace(oldString, newString);
                        Console.WriteLine(sb);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}