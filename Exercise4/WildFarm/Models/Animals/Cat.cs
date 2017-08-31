using System;

namespace WildFarm.Models.Animals
{
    public class Cat : Felime
    {
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string catBreed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.CatBreed = catBreed;

        }
        public string CatBreed { get; set; }
        public override string MakeSound()
        {
            return "Meowwww";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.CatBreed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
