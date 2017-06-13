using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(n));
        }
        static int TrailingZeroes(int n)
        {
            int sum = 0;

            for (int i = n / 5; i > 0; i /= 5) sum += i;

            return sum;
        }
    }
}
