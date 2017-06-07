using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                totalSum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
