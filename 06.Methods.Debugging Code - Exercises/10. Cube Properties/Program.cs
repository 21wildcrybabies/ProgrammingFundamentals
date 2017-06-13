using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = (Console.ReadLine());
            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}", Face(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}", Space(side));
            }
            if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}", Volume(side));
            }
            if (parameter == "area")
            {
                Console.WriteLine("{0:F2}", Surface(side));
            }
        }
        static double Face(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }
        static double Space(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }
        static double Volume(double side)
        {
            double result = side * side * side;
            return result;
        }
        static double Surface(double side)
        {
            double result = 6 * (side * side);
            return result;
        }
    }
}