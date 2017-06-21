using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split()
                .ToList();

            for (int i = 0; i < numList.Count; i++)
            {
                numList[i] = ReversedString(numList[i]);
            }

            Console.WriteLine(numList.Select(int.Parse).ToList().Sum());
        }

        static string ReversedString(string s)
        {
            var array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}