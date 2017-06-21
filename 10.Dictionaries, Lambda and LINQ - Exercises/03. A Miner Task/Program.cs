using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var mines = new Dictionary<string, long>();

            while (input != "stop")
            {
                if (mines.ContainsKey(input))
                {
                    mines[input] += long.Parse(Console.ReadLine());
                    input = Console.ReadLine();
                }
                else
                {
                    mines[input] = long.Parse(Console.ReadLine());
                    input = Console.ReadLine();
                }
            }
            foreach (var entry in mines)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}