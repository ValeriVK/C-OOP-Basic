using System.Text;

namespace Avatar.Models.Benders
{
    public class EarthBender : Bender
    {
        public EarthBender(string name, int power, double groundSaturation) : base(name, power)
        {
            this.GroundSaturation = groundSaturation;
            this.TotalPower = this.Power * this.GroundSaturation;
        }

        private double GroundSaturation { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"###Earth Bender: {base.ToString()}, Ground Saturation: {this.GroundSaturation:f2}");

            return sb.ToString().Trim();
        }

    }
}