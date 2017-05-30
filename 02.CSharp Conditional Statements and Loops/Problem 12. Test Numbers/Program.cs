using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumer = int.Parse(Console.ReadLine());
            int sum = 0;
            int totalCominations = 0;
            bool isMagicalNumber = false;
            for (int i = n; i >= 1; i--)
            {
                for (int d = 1; d <= m; d++)
                {
                    if (sum >= magicNumer)
                    {
                        isMagicalNumber = true;
                        break;
                    }
                    else
                    {
                        totalCominations++;
                        sum += 3 * (i * d);
                    }
                }
                if (sum >= magicNumer)
                {
                    isMagicalNumber = true;
                    break;
                }
            }
            Console.WriteLine($"{totalCominations} combinations");
            if (isMagicalNumber)
            {
                Console.WriteLine($"Sum: {sum} >= {magicNumer}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
