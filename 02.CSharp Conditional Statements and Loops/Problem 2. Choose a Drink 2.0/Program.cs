using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (proffesion == "Athlete")
            {
                var price = quantity * 0.70;
                Console.WriteLine($"The Athlete has to pay {price:f2}.");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                var price = quantity * 1.00;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");
            }
            else if (proffesion == "SoftUni Student")
            {
                var price = quantity * 1.70;
                Console.WriteLine($"The SoftUni Student has to pay {price:f2}.");
            }
            else
            {
                var price = quantity * 1.20;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");
            }
        }
    }
}
