using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string user = tokens[0];
                string team = tokens[1];

                if (teams.Any(x => x.Name == team)) Console.WriteLine($"Team {team} was already created!");
                else if (teams.Any(x => x.Creator == user)) Console.WriteLine($"{user} cannot create another team!");
                else
                {
                    Team newTeam = new Team(user, team, new List<string>());
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") break;

                string[] tokens = input.Split("->");
                string user = tokens[0];
                string team = tokens[1];

                Team thisTeam = teams.Find(x => x.Name == team);
                int index = teams.IndexOf(thisTeam);

                if (!teams.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                else if (teams.Any(x => x.Members.Contains(user)) || teams[index].Creator == user)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }
                else
                {
                    thisTeam = teams.Find(x => x.Name == team);
                    index = teams.IndexOf(thisTeam);
                    teams[index].Members.Add(user);
                    continue;
                }
            }

            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in teams)
            {
                if (team.Members.Count > 0)
                {
                    team.Members.Sort();
                    Console.WriteLine(team.Name);
                    Console.WriteLine($"- {team.Creator}");

                    foreach (var member in team.Members)
                        Console.WriteLine("-- " + member);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams)
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }

    class Team
    {
        public Team(string creator, string teamName, List<string> members)
        {
            Creator = creator;
            Name = teamName;
            Members = members;
        }
        public string Creator { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }
    }
}