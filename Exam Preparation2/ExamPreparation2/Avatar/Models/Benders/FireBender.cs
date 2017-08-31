using System.Text;

namespace Avatar.Models.Benders
{
    public class FireBender : Bender
    {
        public FireBender(string name, int power, double heatAggression) : base(name, power)
        {
            this.HeatAggression = heatAggression;
            this.TotalPower = this.Power * this.HeatAggression;
        }

        public double HeatAggression { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"###Fire Bender: {base.ToString()}, Heat Aggression: {this.HeatAggression:f2}");

            return sb.ToString().Trim();
        }
    }
}