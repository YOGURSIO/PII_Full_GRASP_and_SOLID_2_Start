using System;
using System.Collections;

/*  
Esta clase se encarga de imprimir la receta, asi aplicando el SRP
*/

namespace Full_GRASP_And_SOLID.Library
{
    public class Printer
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:"); 
            foreach (Step step in recipe.Steps)     
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " + 
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}