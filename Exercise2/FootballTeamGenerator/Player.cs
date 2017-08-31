using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double skillLevel;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.skillLevel = (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0; 
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }
                this.name = value;
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            set
            {
                if (0 >= value || value >= 100)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            set
            {
                if (0 >= value || value >= 100)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            set
            {
                if (0 >= value || value >= 100)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            set
            {
                if (0 >= value || value >= 100)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }
                this.passing = value;
            }
        }

        public int Shooting
        {
            get { return this.shooting; }
            set
            {
                if (0 >= value || value >= 100)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }
                this.shooting = value;
            }
        }
        public double SkillLevel
        {
            get { return this.skillLevel; }
            //set
            //{
            //    this.skillLevel = value;
            //}
        }

        //private double GetSkillLevel()
        //{
        //    this.skillLevel = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        //    return this.SkillLevel;
        //}
    }
}