using System.Text;

namespace Avatar.Models.Benders
{
    public class WaterBender : Bender
    {
        public WaterBender(string name, int power, double waterClarity) : base(name, power)
        {
            this.WaterClarity = waterClarity;
            this.TotalPower = this.WaterClarity * this.Power;
        }
        private double WaterClarity { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"###Water Bender: {base.ToString()}, Water Clarity: {this.WaterClarity:f2}");

            return sb.ToString().Trim();
        }
    }
}