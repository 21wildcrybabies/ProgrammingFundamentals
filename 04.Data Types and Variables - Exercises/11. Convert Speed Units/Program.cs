using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceMet = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            float allMin = (hours * 60.0f) + minutes;
            float allSec = (allMin * 60.0f) + seconds;
            float allHours = (allSec / 60.0f) / 60.0f;
            float distanceKm = (float)(distanceMet / 1000.0);
            var distanceMiles = distanceMet / 1609.0f;
            float metersPerSecond = distanceMet / allSec;
            float kmPerHour = distanceKm / allHours;
            float milesPerHour = distanceMiles / allHours;
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
