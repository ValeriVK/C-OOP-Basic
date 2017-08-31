using System.Text;

namespace Avatar.Models.Monuments
{
    public class AirMonument : Monument
    {
        public AirMonument(string name, int airAffinity) : base(name)
        {
            this.AirAffinity = airAffinity;
            this.Affinity = this.AirAffinity;
        }

        private int AirAffinity { get; set; }
    
    

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"###Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}");
            return sb.ToString().Trim();
        }

    }
}//###Fire Monument: JerseyGrew, Fire Affinity: 1000