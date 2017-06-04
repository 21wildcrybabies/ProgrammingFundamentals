using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startChar = int.Parse(Console.ReadLine());
            var endChar = int.Parse(Console.ReadLine());
            for (char c = (char)startChar; c <= (char)endChar; c++)
            {
                Console.Write(c + " ");
            }
        }
    }
}
