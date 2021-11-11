using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTeams = int.Parse(Console.ReadLine());
            List<string> creators = new List<string>();
            List<string> teamNames = new List<string>();
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numTeams; i++)
            {
                string[] creatorTeam = Console.ReadLine()
                    .Split("-");
                string creator = creatorTeam[0];
                string teamName = creatorTeam[1];

                bool rulebroken = false;
                bool ruleCreatorBroken = false;
                bool ruleTeamNameBroken = false;
                if (creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    ruleCreatorBroken = true;
                }

                if (teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    ruleTeamNameBroken = true;
                }
                if (ruleCreatorBroken || ruleTeamNameBroken)
                {
                    rulebroken = true;
                }
                if (rulebroken == false)
                {
                    Team team = new Team
                    {
                        Creator = creator,
                        TeamName = teamName
                    };
                    creators.Add(creator);
                    teamNames.Add(teamName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] userTeam = input
                    .Split("->");
                string user = userTeam[0];
                string teamName = userTeam[1];

                Team team = GetTeamByName(teams, teamName);
                if (!teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                team.TeamMembers.Add(user);
                team.MemberCount++;
            }
            teams = teams.OrderByDescending(i => i.MemberCount).ThenBy(y => y.TeamName).ToList();
            foreach (Team team in teams)
            {
                team.TeamMembers.Sort();
                if (team.MemberCount < 1)
                {
                    continue;
                }
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.TeamMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams)
            {
                if (team.MemberCount < 1)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }

        private static Team GetTeamByName(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return team;
                }
            }
            return null;
        }

        private static bool IsMember(string user, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }

                foreach (var member in team.TeamMembers)
                {
                    if (user == member)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public class Team
    {
        public Team()
        {
            TeamMembers = new List<string>();
        }
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public int MemberCount { get; set; }

        public List<string> TeamMembers { get; set; }

    }
}