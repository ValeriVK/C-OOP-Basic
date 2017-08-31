using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Team
    {
        private string teamName;
        private double rating;
        private List<Player> players;

        public Team(string name)
        {
            this.TeamName = name;
            this.Rating = rating;
            this.players = new List<Player>();
        }

        public string TeamName
        {
            get { return this.teamName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.teamName = value;
            }
        }
        public double Rating
        {
            get { return this.rating; }
            set
            {
                this.rating = value;
            }
        }
        public double GetRating()
        {
            if (this.players.Count > 0)
            {
                this.rating = this.players.Select(p => p.SkillLevel).Average();
                
            }
            else
            {
                this.rating = 0;
            }
                return this.rating;
        }

        public void AddPlayer(Player playerToAdd)
        {
            //playerToAdd.GetSkillLevel();
            players.Add(playerToAdd);
        }

        public void RemovePlayer(string nameOfPlayerToRemove)
        {
            var playerToRemove = this.players.Where(p => p.Name == nameOfPlayerToRemove).FirstOrDefault();
            if (!this.players.Contains(playerToRemove))
            {
                throw new ArgumentException($"Player {nameOfPlayerToRemove} is not in {this.TeamName} team.");
            }
            else
            {
                players.Remove(playerToRemove);
            }
        }
    }
}
