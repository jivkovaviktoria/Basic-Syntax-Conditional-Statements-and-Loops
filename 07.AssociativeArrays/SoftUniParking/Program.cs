using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string command = tokens[0];
                string username = tokens[1];

                if (command == "register")
                {
                    string plate = tokens[2];

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                }
                else if(command=="unregister")
                {
                    if(users.ContainsKey(username))
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: user {username} not found");
                }
            }

            foreach (var (username, plate) in users)
                Console.WriteLine($"{username} => {plate}");
        }
    }
}
