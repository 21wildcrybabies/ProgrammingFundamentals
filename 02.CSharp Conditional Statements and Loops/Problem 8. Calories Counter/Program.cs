﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < input; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    calories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredients == "salami")
                {
                    calories += 600;
                }
                else if (ingredients == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
