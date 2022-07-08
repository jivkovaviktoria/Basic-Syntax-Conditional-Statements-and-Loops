using System;
using System.Collections.Generic;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> pieces = new Dictionary<string, string>();
            Dictionary<string, string> keys = new Dictionary<string, string>();
            List<string> order = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] arguments = line.Split('|');
                string piece = arguments[0];
                string composer = arguments[1];
                string key = arguments[2];

                pieces.Add(piece, composer);
                keys.Add(piece, key);
                order.Add(piece);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] tokens = input.Split("|");
                string command = tokens[0];

                if (command == "Add")
                {
                    string piece = tokens[1];
                    string composer = tokens[2];
                    string key = tokens[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, composer);
                        keys.Add(piece, key);
                        order.Add(piece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                        Console.WriteLine($"{piece} is already in the collection!");
                }
                else if (command == "Remove")
                {
                    string piece = tokens[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        keys.Remove(piece);
                        order.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                else if (command == "ChangeKey")
                {
                    string piece = tokens[1];
                    string newKey = tokens[2];

                    if (pieces.ContainsKey(piece))
                    {
                        keys[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }

                input = Console.ReadLine();
            }

            foreach (var piece in order)
            {
                string key = keys[piece];
                string composer = pieces[piece];
                Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}
