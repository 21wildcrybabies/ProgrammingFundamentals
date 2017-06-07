using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long sbytePrice = 0;
            long intPrice = 0;
            long totalPrice = 0;

            if (num1 >= 0 && num1 <= sbyte.MaxValue)
            {
                sbytePrice = num1 * 4;
            }
            else if (num2 >= 0 && num2 <= sbyte.MaxValue)
            {
                sbytePrice = num2 * 4;
            }

            if (num1 >= 128 && num1 <= int.MaxValue)
            {
                intPrice = num1 * 10;
            }
            else if (num2 >= 128 && num2 <= int.MaxValue)
            {
                intPrice = num2 * 10;
            }

            totalPrice = sbytePrice + intPrice;
            Console.WriteLine(totalPrice);
        }
    }
}