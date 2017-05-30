using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int matchCount = 0;
            for (int i = m; i >= n; i--)
            {
                for (int d = m; d >= n; d--)
                {
                    sum = i + d;
                    count++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {d} = {magicNumber}");
                        return;
                    }
                }
            }
            if (matchCount == 0)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
