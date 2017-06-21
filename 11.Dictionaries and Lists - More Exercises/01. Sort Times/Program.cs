using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split().ToList();

            times = times.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", times));
        }
    }
}