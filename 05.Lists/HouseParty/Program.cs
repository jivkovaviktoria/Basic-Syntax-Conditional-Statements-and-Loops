using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfGuests; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];
                if (command[2] == "going!")
                {
                    if (!guests.Contains(name)) guests.Add(name);
                    else Console.WriteLine($"{name} is already in the list!");
                }
                else if(command[2] == "not")
                {
                    if (guests.Contains(name)) guests.Remove(name);
                    else Console.WriteLine($"{name} is not in the list!");
                }
            }
            foreach(var name in guests)
                Console.WriteLine(name);

        }
    }
}
