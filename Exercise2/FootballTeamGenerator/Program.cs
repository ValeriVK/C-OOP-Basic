using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    var inputTokens = input.Split(';');
                    var command = inputTokens[0];
                    var teamName = inputTokens[1];
                    switch (command)
                    {
                        case "Team":
                            {
                                var team = new Team(teamName);
                                teams.Add(team);
                            }
                            break;
                        case "Add":
                            {
                                var chekTeam = teams.Where(t => t.TeamName == teamName).FirstOrDefault();
                                if (!teams.Contains(chekTeam))
                                {
                                    Console.WriteLine($"Team {teamName} does not exist.");
                                }
                                else
                                {
                                    var playerToAdd = new Player(inputTokens[2], int.Parse(inputTokens[3]), int.Parse(inputTokens[4]), int.Parse(inputTokens[5]), int.Parse(inputTokens[6]), int.Parse(inputTokens[7]));
                                    //playerToAdd.GetSkillLevel();
                                    chekTeam.AddPlayer(playerToAdd);
                                }
                            }
                            break;
                        case "Remove":
                            {
                                var chekTeam = teams.Where(t => t.TeamName == teamName).FirstOrDefault();
                                chekTeam.RemovePlayer(inputTokens[2]);

                            }
                            break;
                        case "Rating":
                            {
                                var chekTeam = teams.Where(t => t.TeamName == teamName).FirstOrDefault();
                                if (!teams.Contains(chekTeam))
                                {
                                    Console.WriteLine($"Team {teamName} does not exist.");
                                }
                                else
                                {
                                    chekTeam.GetRating();
                                    var rating = Math.Round(chekTeam.Rating);
                                    Console.WriteLine($"{chekTeam.TeamName} - {rating}");
                                }
                            }
                            break;
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
