using System.Text;

namespace Avatar.Models.Monuments
{
    public class WaterMonument : Monument
    {
        public WaterMonument(string name ,int waterAffinity) : base(name)
        {
            this.WaterAffinity = waterAffinity;
            this.Affinity = this.WaterAffinity;
        }

        private int WaterAffinity { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"###Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}");
            return sb.ToString().Trim();
        }
    }
}