using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter the name of the recipe:");
        string recipeName = Console.ReadLine();

        Console.WriteLine("Enter the number of ingredients:");
        int numIngredients = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the details of each ingredient:");

        for (int i = 1; i <= numIngredients; i++)
        {
            Console.WriteLine($"Ingredient {i}:");
            string ingredientName = Console.ReadLine();

            Console.WriteLine($"Units of measurement for {ingredientName}:");
            string measurementUnits = Console.ReadLine();

            Console.WriteLine($"Quantity of {ingredientName}:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("Recipe Details:");
        Console.WriteLine($"Recipe Name: {recipeName}");
        Console.WriteLine($"Number of Ingredients: {numIngredients}");

        Console.WriteLine("Ingredients:");

        for (int i = 1; i <= numIngredients; i++)
        {
            Console.WriteLine($"Ingredient {i}:");
            string ingredientName = Console.ReadLine();

            Console.WriteLine($"Units of measurement: {measurementUnits}");
            string measurementUnits = Console.ReadLine();

            Console.WriteLine($"Quantity: {quantity}");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }
}