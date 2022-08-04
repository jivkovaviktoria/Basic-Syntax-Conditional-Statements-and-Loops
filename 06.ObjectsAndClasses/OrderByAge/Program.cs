using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                if(people.Any(x => x.Id == id))
                {
                    Person person = people.Find(x => x.Id == id);
                    int index = people.IndexOf(person);

                    people[index].Name = name;
                    people[index].Age = age;
                }
                else
                {
                    Person newPerson = new Person(name, id, age);
                    people.Add(newPerson);
                }

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var person in people)
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}