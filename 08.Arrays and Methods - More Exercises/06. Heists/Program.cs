using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lootPrices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var totalMoney = 0.0;
            var jewelsPrice = lootPrices[0];
            var goldPrice = lootPrices[1];

            while (command != "Jail Time")
            {
                var heistElements = command.Split(' ').ToArray();
                int jewelsQuantity = heistElements[0].Where(ch => ch == '%').Count();
                int goldQuantity = heistElements[0].Where(ch => ch == '$').Count();
                var currentHeistCost = double.Parse(heistElements[1]);
                totalMoney += (jewelsQuantity * jewelsPrice) +(goldQuantity * goldPrice) - currentHeistCost;
                
                command = Console.ReadLine();
            }

            Console.WriteLine(
                totalMoney < 0 ?
                $"Have to find another job. Lost: {Math.Abs(totalMoney)}." :
                $"Heists will continue. Total earnings: {totalMoney}."
                );
        }
    }
}
