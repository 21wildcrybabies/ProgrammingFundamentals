using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            try
            {
                long m = long.Parse(n);
                Console.WriteLine($"{m} can fit in:");

                var types = new List<string>();
                types.Add("sbyte");
                types.Add("byte");
                types.Add("short");
                types.Add("ushort");
                types.Add("int");
                types.Add("uint");
                types.Add("long");

                foreach (var type in types)
                {
                    long minimum = 0;
                    long maximum = 0;

                    switch (type)
                    {
                        case "sbyte":
                            minimum = sbyte.MinValue;
                            maximum = sbyte.MaxValue;
                            break;
                        case "byte":
                            minimum = byte.MinValue;
                            maximum = byte.MaxValue;
                            break;
                        case "short":
                            minimum = short.MinValue;
                            maximum = short.MaxValue;
                            break;
                        case "ushort":
                            minimum = ushort.MinValue;
                            maximum = ushort.MaxValue;
                            break;
                        case "int":
                            minimum = int.MinValue;
                            maximum = int.MaxValue;
                            break;
                        case "uint":
                            minimum = uint.MinValue;
                            maximum = uint.MaxValue;
                            break;
                        case "long":
                            minimum = long.MinValue;
                            maximum = long.MaxValue;
                            break;
                    }
                    if (m >= minimum && m <= maximum)
                    {
                        Console.WriteLine($"* {type}");
                    }

                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{n} can't fit in any type");
            }

        }

    }
}
