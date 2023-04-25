using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class recipeList
    {
            private int AmtOfIngredients = 0;
            private string[] nameOfIngredient;
            private double[] QuantitiesOfIngredients;
            private string[] UnitsOfIngredient;
            private int numSteps = 0;
            private string[] steps;


            public void DetailedList()
            {
            // Prompt the user to enter the number of ingredients

            Console.Write("Enter number of ingredients: ");
                AmtOfIngredients = Convert.ToInt32(Console.ReadLine());

            // Initialize the arrays with the correct size
                nameOfIngredient = new string[AmtOfIngredients];
                QuantitiesOfIngredients = new double[AmtOfIngredients];
                UnitsOfIngredient = new string[AmtOfIngredients];

                for (int a = 0; a < AmtOfIngredients; a++)
                {
            // Prompt the user to enter the details for each ingredient

                    Console.Write($"Enter ingredient {a+1 } name: ");
                    nameOfIngredient[a] = Console.ReadLine();

                    Console.Write($"Enter ingredient {a+1} quantity: ");
                    QuantitiesOfIngredients[a] = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter ingredient {a+1} unit: ");
                    UnitsOfIngredient[a] = Console.ReadLine();
                }
            // Prompt the user to enter the number of steps

                Console.Write("Enter number of steps: ");
                numSteps = Convert.ToInt32(Console.ReadLine());

            // Initialize the steps array with the correct size
                steps = new string[numSteps];

            for (int a = 0; a < numSteps; a++)
            {
                // Prompt the user to enter the details for each step
                Console.WriteLine($"Enter step {a + 1}");
                
                  steps[a] = Console.ReadLine();
                }

                Console.WriteLine("details stored successfully.");
            }


            public void Display()
            {
            // Display the ingredients and quantities

                Console.WriteLine("Recipe:");

                for (int b = 0; b < AmtOfIngredients; b++)
                {
                Console.WriteLine(QuantitiesOfIngredients[b] + "  ingredient/s");
                Console.WriteLine(UnitsOfIngredient[b]+" unit/s");
                Console.WriteLine(nameOfIngredient[b]);
                }

            // Display the steps
                for (int b = 0; b < numSteps; b++)
                {
                    Console.WriteLine($"Steps {b + 1}: {steps[b]}");
                }

            }

            public void ScaleRecipe()
            {
            // Multiply all the quantities by the scaling factor
                Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                double scalingFactor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < AmtOfIngredients; i++)
                {
                    QuantitiesOfIngredients[i] *= scalingFactor;
                }

                Console.WriteLine("Recipe scaled successfully.");

            }

            public void ResetInformation()
            {
            // Reset all the quantities to their original values
                for (int c = 0; c < AmtOfIngredients; c++)
                {
                    QuantitiesOfIngredients[c] /= 2;

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

