using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string input = Console.ReadLine();
            string[] person = input.Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < person.Length; i++)
            {
                string[] tokens = person[i].Split('=');
                string name = tokens[0];
                double money = double.Parse(tokens[1]);

                Person newPerson = new Person(name, money);
                people.Add(newPerson);
            }


            input = Console.ReadLine();
            string[] product = input.Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < product.Length; i++)
            {
                string[] tokens = product[i].Split('=');
                string name = tokens[0];
                double cost = double.Parse(tokens[1]);

                Product newProduct = new Product(name, cost);
                products.Add(newProduct);
            }

            input = Console.ReadLine();
            while (input!="END")
            {
                string[] tokens = input.Split();
                string currentPerson = tokens[0];
                string currentProduct = tokens[1];

                Person thisPerson = people.Find(x => x.Name == currentPerson);
                Product thisProduct = products.Find(x => x.Name == currentProduct);

                if (thisPerson.Money >= thisProduct.Cost)
                {
                    thisPerson.Money -= thisProduct.Cost;

                    thisPerson.Products.Add(thisProduct);
                    Console.WriteLine($"{thisPerson.Name} bought {thisProduct.Name}");
                }
                else Console.WriteLine($"{thisPerson.Name} can't afford {thisProduct.Name}");
                

                input = Console.ReadLine();
            }

            foreach (var p in people)
            {
                var listOfProducts = p.Products.Select(x => x.Name);
                if (p.Products.Count > 0) Console.WriteLine($"{p.Name} - {string.Join(", ", listOfProducts)}");
                else Console.WriteLine($"{p.Name} - Nothing bought");
            }
        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            List<Product> products = new List<Product>();

            Name = name;
            Money = money;
            Products = products;
        }

        public string Name { get; set; }

        public double Money { get; set; }

        public List<Product> Products { get; set; }
    }

    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public double Cost { get; set; }
    }
}