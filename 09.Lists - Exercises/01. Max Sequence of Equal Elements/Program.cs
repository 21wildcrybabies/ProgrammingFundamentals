using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();
            var finalList = new List<int>();
            int counter = 1;
            int maxCounter = 1;

            resultList.Add(originalNumbers[0]);

            for (int i = 0; i < originalNumbers.Count - 1; i++)
            {
                if (originalNumbers[i] == originalNumbers[i + 1])
                {
                    counter++;
                    resultList.Add(originalNumbers[i + 1]);
                }
                else
                {
                    counter = 1;
                    resultList.Clear();
                    resultList.Add(originalNumbers[i + 1]);
                }
                if (counter > maxCounter)
                {
                    finalList.Clear();
                    maxCounter = counter;
                    finalList.AddRange(resultList);
                }
            }

            if (maxCounter == 1)
            {
                Console.WriteLine(originalNumbers[0]);
                return;
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}