using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var spaces = n;
            for (var i = 0; i < (n / 2) + 1; i++)   
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                spaces = spaces - 2;
                if (spaces < 0)
                {
                    break;
                }
                Console.Write(new string(' ', spaces));
                Console.WriteLine("x");
            }
            Console.WriteLine();
            var newspaces = 0;
            var centerSpaces = 1;
            for (var k = n / 2; k > 0; k--)
            {
                newspaces = k - 1;
                Console.Write(new string(' ', newspaces));
                Console.Write("x");
                Console.Write(new string(' ', centerSpaces));
                Console.Write("x");
                Console.WriteLine();
                centerSpaces += 2;
            }
            Console.WriteLine();
        }
    }
}