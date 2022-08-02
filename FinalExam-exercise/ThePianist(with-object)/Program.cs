using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist_with_object_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
            List<string> order = new List<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split('|').ToArray();
                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];

                pieces.Add(piece, new Piece(composer, key));
                order.Add(piece);
            }

            string input = Console.ReadLine();
            while (input!="Stop")
            {
                string[] tokens = input.Split('|').ToArray();
                string command = tokens[0];
                string piece = tokens[1];

                if (command == "Add")
                {
                    string composer = tokens[2];
                    string key = tokens[3];
                    if(!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new Piece(composer, key));
                        order.Add(piece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else Console.WriteLine($"{piece} is already in the collection!");
                }
                else if(command=="Remove")
                {
                    if(pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        order.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                else if(command=="ChangeKey")
                {
                    string newKey = tokens[2];
                    if(pieces.ContainsKey(piece))
                    {
                        pieces[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                input = Console.ReadLine();
            }

            foreach (var piece in order)
                Console.WriteLine($"{piece} -> Composer: {pieces[piece].Composer}, Key: {pieces[piece].Key}");
            
        }
    }

    class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }

        public string Key { get; set; }
    }
}