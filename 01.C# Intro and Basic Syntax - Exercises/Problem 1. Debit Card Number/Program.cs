using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            Console.Write($"{n:D4} ");
            Console.Write($"{n1:D4} ");
            Console.Write($"{n2:D4} ");
            Console.Write($"{n3:D4}");
        }
    }
}
