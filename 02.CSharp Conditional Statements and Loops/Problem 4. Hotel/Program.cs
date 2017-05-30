using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    break;
            }
            if ((month == "May" || month == "October") && nightsCount > 7)
            {
                priceStudio *= 0.95;
            }
            else if ((month == "June" || month == "September") && nightsCount > 14)
            {
                priceDouble *= 0.90;
            }
            else if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                priceSuite *= 0.85;
            }
            double allPriceStudio = priceStudio * nightsCount;
            double allPriceDouble = priceDouble * nightsCount;
            double allPriceSuite = priceSuite * nightsCount;
            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                allPriceStudio = (priceStudio * nightsCount) - priceStudio; 
            }
            Console.WriteLine($"Studio: {allPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {allPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {allPriceSuite:f2} lv.");
        }
    }
}
