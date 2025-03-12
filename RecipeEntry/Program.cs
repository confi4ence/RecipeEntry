using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe Entry System!");

            // Get number of ingredients
            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            List<Ingredient> ingredients = new List<Ingredient>();

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"\nEnter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                ingredients.Add(new Ingredient(name, quantity, unit));
            }

            // Get number of steps
            Console.Write("\nEnter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            List<string> steps = new List<string>();

            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Step {i + 1} description: ");
                steps.Add(Console.ReadLine());
            }

            // Display the entered recipe
            Console.WriteLine("\nRecipe Summary:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }

            Console.WriteLine("\nRecipe saved successfully!");
        }
    }

    // Ingredient class
    class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
    

