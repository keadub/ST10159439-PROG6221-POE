using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class recipeList
    {
            private int numIngredients = 0;
            private string[] nameOfIngredient;
            private double[] QuantitiesOfIngredients;
            private string[] UnitsOfIngredient;
            private int numSteps = 0;
            private string[] steps;


            public void RecipeDetailList()
            {
            // Prompt the user to enter the number of ingredients

            Console.Write("Enter number of ingredients: ");
                numIngredients = Convert.ToInt32(Console.ReadLine());

            // Initialize the arrays with the correct size
                nameOfIngredient = new string[numIngredients];
                QuantitiesOfIngredients = new double[numIngredients];
                UnitsOfIngredient = new string[numIngredients];

                for (int i = 0; i < numIngredients; i++)
                {
            // Prompt the user to enter the details for each ingredient

                    Console.Write($"Enter ingredient {i+1 } name: ");
                    nameOfIngredient[i] = Console.ReadLine();

                    Console.Write($"Enter ingredient {i+1} quantity: ");
                    QuantitiesOfIngredients[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter ingredient {i+1} unit: ");
                    UnitsOfIngredient[i] = Console.ReadLine();
                }
            // Prompt the user to enter the number of steps

                Console.Write("Enter number of steps: ");
                numSteps = Convert.ToInt32(Console.ReadLine());

            // Initialize the steps array with the correct size
                steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                // Prompt the user to enter the details for each step
                Console.WriteLine($"Enter step {i + 1}");
                
                  steps[i] = Console.ReadLine();
                }

                Console.WriteLine("details stored successfully.");
            }


            public void Display()
            {
            // Display the ingredients and quantities

                Console.WriteLine("Recipe:");

                for (int i = 0; i < numIngredients; i++)
                {
                Console.WriteLine(QuantitiesOfIngredients[i] + "  ingredient/s");
                Console.WriteLine(UnitsOfIngredient[i]+" unit/s");
                Console.WriteLine(nameOfIngredient[i]);
                }

            // Display the steps
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Steps {i + 1}: {steps[i]}");
                }

            }

            public void ScaleRecipe()
            {
            // Multiply all the quantities by the scaling factor
                Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                double scalingFactor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numIngredients; i++)
                {
                    QuantitiesOfIngredients[i] *= scalingFactor;
                }

                Console.WriteLine("Recipe scaled successfully.");

            }

            public void ResetInformation()
            {
            // Reset all the quantities to their original values
                for (int i = 0; i < numIngredients; i++)
                {
                    QuantitiesOfIngredients[i] /= 2;

                }
                Console.WriteLine("Reset successfully.");
            }

            public void ClearRecipe()
            {
            // Reset all the arrays to empty
            Array.Clear(steps, 0, steps.Length);
            Array.Clear(UnitsOfIngredient, 0, UnitsOfIngredient.Length);
            Array.Clear(nameOfIngredient, 0, nameOfIngredient.Length);
            Array.Clear(QuantitiesOfIngredients,0, QuantitiesOfIngredients.Length);
            Console.WriteLine("infomation cleared");
            }
        }
    }

