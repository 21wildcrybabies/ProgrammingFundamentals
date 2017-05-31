using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photosNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            long size = long.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{photosNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D2} {hour:D2}:{minutes:D2}");
            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size < 1000000)
            {
                size /= 1000;
                Console.WriteLine($"Size: {size}KB");
            }
            else
            {
                size /= 1000000;
                Console.WriteLine($"Size: {size}MB");
            }
            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (height == width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
