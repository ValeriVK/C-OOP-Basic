using System.CodeDom;
using System.Security.AccessControl;
using System.Text;

public abstract class Car
{
    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProductionI = yearOfProduction;
        this.HorsePower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    protected string Brand { get; set; }
    protected string Model { get; set; }
    protected int YearOfProductionI { get; set; }
    public int HorsePower { get; set; }
    protected int Acceleration { get; set; }
    public int Suspension { get; set; }
    protected int Durability { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProductionI}");
        sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
        return sb.ToString().Trim();
    }
}