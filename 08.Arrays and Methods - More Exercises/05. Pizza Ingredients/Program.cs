using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(' ').ToArray();
            var maxLenght = int.Parse(Console.ReadLine());
            var count = 0;
            var added = new List<string>();
            for (int i = 0; i < ingredients.Length && count < 10; i++)
            {
                if (ingredients[i].Length == maxLenght)
                {
                    added.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    count++;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", added)}.");
        }
    }
}
