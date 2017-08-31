using System.Text;

namespace Avatar.Models.Benders
{
    public class AirBender : Bender
    {
        private readonly double aerialIntegrity;

        public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
        {
        
            this.aerialIntegrity = aerialIntegrity;

            this.TotalPower = this.aerialIntegrity * this.Power;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
        
            sb.AppendLine($"###Air Bender: {base.ToString()}, Aerial Integrity: {this.aerialIntegrity:f2}");
        
            return sb.ToString().Trim();
        }
    }
}//###Air Bender: Yu, Power: 100, Aerial Integrity: 215.68