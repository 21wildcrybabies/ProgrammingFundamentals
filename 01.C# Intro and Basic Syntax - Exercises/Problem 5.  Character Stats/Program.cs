using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealt = int.Parse(Console.ReadLine());
            var maximumHealt = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string ('|', currentHealt), new string ('.', maximumHealt - currentHealt));
        }
    }
}
