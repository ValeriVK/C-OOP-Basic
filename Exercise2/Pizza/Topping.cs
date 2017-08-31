using System;
public class Topping
{
    private string type;
    private double weight;
    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    private string Type
    {
        set
        {
            if (!(value == "Meat" || value == "Veggies" || value == "Cheese" || value == "Sauce"))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value;
        }
    }
    private double Weight
    {
        set
        {
            if (1 > value || value > 50)
            {
                throw new ArgumentException($"{nameof(this.Type)} weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }

    public double GetToppingCalories()
    {
        double toppingCoeficent = 0;
        switch (this.type)
        {
            case "Meat": toppingCoeficent = 1.2; break;
            case "Veggies": toppingCoeficent = 0.8; break;
            case "Cheese": toppingCoeficent = 1.1; break;
            case "Sauce": toppingCoeficent = 0.9; break;

        }
        return 2 * this.weight * toppingCoeficent;
    }
}

