using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var hexaFormat = Convert.ToInt32(input, 16);
            Console.WriteLine(hexaFormat);
        }
    }
}
