using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            

            while (input!="end")
            {

                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    integers.RemoveAll(x => x == element);
                }
                else if(command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    integers.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
