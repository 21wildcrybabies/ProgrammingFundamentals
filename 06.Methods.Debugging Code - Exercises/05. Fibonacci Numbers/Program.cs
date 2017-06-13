using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fibN = 1;
            var fibN1 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                var next = fibN + fibN1;
                fibN = fibN1;
                fibN1 = next;
            }
            Console.WriteLine(fibN1);
        }
    }
}
