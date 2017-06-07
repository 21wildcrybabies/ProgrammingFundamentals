using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            char sumToLetter;
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                sum = char.Parse(Console.ReadLine()) + key;
                sumToLetter = (char)sum;

                word += sumToLetter;
            }

            Console.WriteLine(word);
        }
    }
}
