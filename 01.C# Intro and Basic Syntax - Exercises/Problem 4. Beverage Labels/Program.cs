using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyPer100 = double.Parse(Console.ReadLine());
            var sugarPer100 = double.Parse(Console.ReadLine());

            var calories = energyPer100 / 100 * volume;
            var sugar = sugarPer100 / 100 * volume;

            Console.WriteLine($"{volume}ml {name}");
            Console.WriteLine($"{calories}kcal, {sugar}g sugars");
        }
    }
}
