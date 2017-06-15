using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var wordToReplace = command[2];
                    try
                    {
                        array[index] = wordToReplace;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
