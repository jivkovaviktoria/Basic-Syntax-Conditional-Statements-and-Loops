using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ").ToList();
            int movesCount = 0;
            string input = Console.ReadLine();

            while (input!="end")
            {
                movesCount++;
                string[] index = input.Split(" ");
                int firstIndex = int.Parse(index[0]);
                int secondIndex = int.Parse(index[1]);

                if(firstIndex==secondIndex || firstIndex>elements.Count-1 || secondIndex > elements.Count-1 || firstIndex<0 || secondIndex<0)
                {
                    int indexToInsert = elements.Count / 2;

                    elements.Insert(indexToInsert, $"-{movesCount}a");
                    elements.Insert(indexToInsert, $"-{movesCount}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if(elements[firstIndex] == elements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                    var element1 = elements[firstIndex];
                    var element2 = elements[secondIndex];
                    elements.Remove(element1);
                    elements.Remove(element2);
                }
                else if (elements[firstIndex] != elements[secondIndex])
                    Console.WriteLine("Try again!");

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if(elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }



        }
    }
}
