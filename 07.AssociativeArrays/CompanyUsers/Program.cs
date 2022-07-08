using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<String>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" -> ");
                string company = tokens[0];
                string id = tokens[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }
                else
                {
                    bool containsId = companies[company].Contains(id);

                    if (!containsId)
                        companies[company].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var id in company.Value)
                    Console.WriteLine("-- " + id);
            }

        }
    }
}
