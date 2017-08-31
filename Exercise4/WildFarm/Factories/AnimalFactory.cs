using WildFarm.Models;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
   public class AnimalFactory
    {
        public static Animal GetAnimal(string[] tokens)
        {
            string animalName = tokens[1];
            string animalType = tokens[0];
            double animalWeight = double.Parse(tokens[2]);
            string animalRegion = tokens[3];
            switch (animalType)
            {
                case "Mouse":
                    return new Mouse(animalName,animalType,animalWeight,animalRegion);
                case "Zebra":
                    return new Zebra(animalName, animalType, animalWeight, animalRegion);
                case "Tiger":
                    return new Tiger(animalName, animalType, animalWeight, animalRegion);
                case "Cat":
                    return new Cat(animalName, animalType, animalWeight, animalRegion,tokens[4]);
                default:
                    return null;
            }
        }
    }
}
