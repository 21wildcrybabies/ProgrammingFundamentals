using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalLiters = 0;
            for (int i = 0; i < n; i++)
            {
                var liters = int.Parse(Console.ReadLine());
                if ((totalLiters + liters) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLiters += liters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
