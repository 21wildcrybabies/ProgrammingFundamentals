using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SearchForANum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = numbers
                .Take(specialNums[0])
                .Skip(specialNums[1])
                .ToList();

            if (numbers.Contains(specialNums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}