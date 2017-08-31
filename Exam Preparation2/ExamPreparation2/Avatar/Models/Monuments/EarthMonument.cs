using System.Text;

namespace Avatar.Models.Monuments
{
    public class EarthMonument : Monument
    {
        public EarthMonument(string name, int earthAffinity) : base(name)
        {
            this.EarthAffinity = earthAffinity;
            this.Affinity = this.EarthAffinity;
        }

        private int EarthAffinity { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"###Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}");
            return sb.ToString().Trim();
        }
    }
}