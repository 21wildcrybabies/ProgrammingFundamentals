using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            try
            {
                sbyte.Parse(num);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(num);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(num);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(num);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}