using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    private double Weight
    {
        set
        {
            if (1 > value || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    private string BakingTechnique
    {
        set
        {
            bool validTechnique = (value == "Crispy" || value == "Chewy" || value == "Homemade");
            if (!validTechnique)
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    private string FlourType
    {
        set
        {
            bool validType = (value == "White" || value == "Wholegrain");
            if (!validType)
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    public double GetDoughCalories()
    {
        double flourCoeficent = (this.flourType == "White") ? 1.5 : 1.0;
        double bakingCoeficent = 0;
        switch (this.bakingTechnique)
        {
            case "Crispy": bakingCoeficent = 0.9; break;
            case "Chewy": bakingCoeficent = 1.1; break;
            case "Homemade": bakingCoeficent = 1.0; break;
        }
        return 2 * this.weight * flourCoeficent * bakingCoeficent;
    }
}