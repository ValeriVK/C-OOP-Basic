using System.Text;

namespace Avatar.Models.Benders
{
    public abstract class Bender
    {
        private double totalPower;
        private string name;
        private int power;

        protected Bender(string name, int power)
        {
            this.name = name;
            this.power = power;

        }

        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected int Power
        {
            get { return this.power; }
            
        }

        public double TotalPower
        {
            get { return this.totalPower; }
            protected set { this.totalPower = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name}, Power: {this.Power}");
            return sb.ToString().Trim();
        }
    }
}
