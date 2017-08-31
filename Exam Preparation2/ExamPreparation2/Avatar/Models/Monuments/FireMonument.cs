using System.Text;

namespace Avatar.Models.Monuments
{
    public class FireMonument : Monument
    {
        public FireMonument(string name, int fireAffinity) : base(name)
        {
            this.FireAffinity = fireAffinity;
            this.Affinity = this.FireAffinity;
        }

        public int FireAffinity { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"###Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}");
            return sb.ToString().Trim();
        }
    }
}