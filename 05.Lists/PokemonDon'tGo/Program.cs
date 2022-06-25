using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while(pokemons.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                int value;

                if (index < 0)
                {
                    value = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index > pokemons.Count - 1)
                {
                    value = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    value = pokemons[index];
                    pokemons.RemoveAt(index);
                }
                    sum += value;

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= value) pokemons[i] += value;
                    else if (pokemons[i] > value) pokemons[i] -= value;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
