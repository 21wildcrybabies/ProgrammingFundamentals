using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = long.Parse(Console.ReadLine());
            if (array.Contains(n))
            {
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == n)
                    {
                        index = i;
                    }
                }
                Console.WriteLine(array.Take(index).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
