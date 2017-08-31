using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.HorsePower *=  150 / 100;
        this.Suspension *= 75 / 100;
    }

    public List<string> AddOns { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (this.AddOns.Count != 0)
        {
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Add-ons: {string.Join(", ", this.AddOns)}");
        }
        sb.AppendLine(base.ToString());
        sb.AppendLine("Add-ons: None");
        return sb.ToString().Trim();
    }
}