using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string concatedWords = string.Empty;
            string words = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                words = Console.ReadLine();

                if (evenOrOdd == "odd")
                {
                    if (i % 2 == 1)
                    {
                        concatedWords += words + delimiter;
                    }
                }

                else if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        concatedWords += words + delimiter;
                    }
                }
            }
            Console.WriteLine(concatedWords.Remove(concatedWords.Length - 1));
        }
    }
}
