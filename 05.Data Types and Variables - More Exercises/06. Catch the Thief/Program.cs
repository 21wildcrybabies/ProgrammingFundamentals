using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int numberOfIDs = int.Parse(Console.ReadLine());
            long thiefID = long.MinValue;

            for (int i = 0; i < numberOfIDs; i++)
            {
                string currentID = Console.ReadLine();

                if (numeralType == "sbyte")
                {
                    try
                    {
                        sbyte currentIDNum = sbyte.Parse(currentID);
                        thiefID = Math.Max(thiefID, currentIDNum);
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (numeralType == "int")
                {
                    try
                    {
                        int currentIDNum = int.Parse(currentID);
                        thiefID = Math.Max(thiefID, currentIDNum);
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (numeralType == "long")
                {
                    try
                    {
                        long currentIDNum = long.Parse(currentID);
                        thiefID = Math.Max(thiefID, currentIDNum);
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            Console.WriteLine(thiefID);
        }
    }
}