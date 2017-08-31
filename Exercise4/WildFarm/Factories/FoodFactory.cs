using WildFarm.Models;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
   public class FoodFactory
    {
        public static Food GetFood(string[] tokens)
        {
            var foodType = tokens[0];
            var foodQuantity = int.Parse(tokens[1]);

            if (foodType == "Meet")
            {
                return new Meet(foodQuantity);
            }
            return new Vegetable(foodQuantity);
        }
    }
}
