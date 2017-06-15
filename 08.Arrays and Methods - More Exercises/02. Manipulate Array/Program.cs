using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                    continue;
                }
                if (command[0] == "Distinct") 
                {
                    array = array.Distinct().ToArray();
                    continue;
                }
                if (command[0] == "Replace")
                {

                    var index = int.Parse(command[1]);
                    var wordToReplace = command[2];
                    array[index] = wordToReplace;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
