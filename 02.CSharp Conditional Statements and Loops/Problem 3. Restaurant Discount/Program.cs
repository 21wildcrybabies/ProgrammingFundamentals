using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            string hallName = "hall";
            double hallPrice = 0;
            double packagePrice = 0;
            double totalPrice = 0;
            double pricePerPerson = 0;
            if (groupsize > 0 && groupsize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;

                if (package == "Normal")
                {
                    packagePrice = 500;
                    totalPrice = (hallPrice + packagePrice) * 0.95;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = (hallPrice + packagePrice) * 0.90;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    totalPrice = (hallPrice + packagePrice) * 0.85;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupsize > 50 && groupsize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;

                if (package == "Normal")
                {
                    packagePrice = 500;
                    totalPrice = (hallPrice + packagePrice) * 0.95;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = (hallPrice + packagePrice) * 0.90;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    totalPrice = (hallPrice + packagePrice) * 0.85;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupsize > 100 && groupsize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;

                if (package == "Normal")
                {
                    packagePrice = 500;
                    totalPrice = (hallPrice + packagePrice) * 0.95;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = (hallPrice + packagePrice) * 0.90;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    totalPrice = (hallPrice + packagePrice) * 0.85;

                    pricePerPerson = totalPrice / groupsize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}