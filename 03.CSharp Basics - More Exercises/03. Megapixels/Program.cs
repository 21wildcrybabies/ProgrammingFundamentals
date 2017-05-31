using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            long width = long.Parse(Console.ReadLine());
            long height = long.Parse(Console.ReadLine());
            double megapixels = Math.Round(width * height / 1000000.0, 1);
            Console.WriteLine($"{width}x{height} => {megapixels}MP");
        }
    }
}
