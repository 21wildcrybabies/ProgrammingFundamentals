using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = 0;
            var min = 0;
            var sum = 0;
            var average = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                max = array.Max();
                min = array.Min();
                sum = array.Sum();
                average = array.Average();
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
