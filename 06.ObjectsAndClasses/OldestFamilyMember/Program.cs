using System;
using System.Linq;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family(new List<Person>());
            
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember.Name + " " + oldestMember.Age);
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Family
    {
        public Family(List<Person> members)
        {
            People = members;
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(x => x.Age).FirstOrDefault();
        }
          
        public void AddMember(Person person) => People.Add(person);
        
        public List<Person> People { get; }
    }
}