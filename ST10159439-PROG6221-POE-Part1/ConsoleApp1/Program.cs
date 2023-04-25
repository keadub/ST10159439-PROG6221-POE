using ConsoleApp1;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        //input data to gather information from the user
        recipeList recipe = new recipeList();

        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset recipe");
            Console.WriteLine("5. Clear recipe data");
            Console.WriteLine("6. Quit");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            string action = Console.ReadLine();
            Console.WriteLine();

            switch (action)
            {
                case "1":
                    recipe.RecipeDetailList();
                    break;

                case "2":
                    recipe.Display();
                    break;

                case "3":
                    recipe.ScaleRecipe();
                    break;

                case "4":
                    recipe.ResetInformation();
                    break;

                case "5":
                    recipe.ClearRecipe();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}