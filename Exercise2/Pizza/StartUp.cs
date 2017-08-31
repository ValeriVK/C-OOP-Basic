using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var dough = new Dough("White", "Chewy", 100);
            var topping = new Topping("Meat", 30);
            Console.WriteLine($"{dough.GetDoughCalories():f2}");
            Console.WriteLine($"{topping.GetToppingCalories():f2}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

