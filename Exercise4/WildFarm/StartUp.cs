using System;
using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm
{
    internal class StartUp
    {
        private static Animal animalFactory;

        private static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodTokens = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var animal = AnimalFactory.GetAnimal(animalTokens);
                var food = FoodFactory.GetFood(foodTokens);
                Console.WriteLine(animal.MakeSound());
               
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
