using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TouristInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            var converted = 0.0;

            switch (imperialUnit)
            {
                case "miles":
                    converted = value * 1.6;
                    Console.WriteLine($"{value} miles = {converted:f2} kilometers");
                    break;
                case "inches":
                    converted = value * 2.54;
                    Console.WriteLine($"{value} inches = {converted:f2} centimeters");
                    break;
                case "feet":
                    converted = value * 30;
                    Console.WriteLine($"{value} feet = {converted:f2} centimeters");
                    break;
                case "yards":
                    converted = value * 0.91;
                    Console.WriteLine($"{value} yards = {converted:f2} meters");
                    break;
                case "gallons":
                    converted = value * 3.8;
                    Console.WriteLine($"{value} gallons = {converted:f2} liters");
                    break;
            }
        }
    }
}