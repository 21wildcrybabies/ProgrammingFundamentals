using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pi = Math.PI;
            double biggestKegVolume = 0;
            string biggestKegModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());

                double volume = pi * radiusKeg * radiusKeg *heightKeg;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
