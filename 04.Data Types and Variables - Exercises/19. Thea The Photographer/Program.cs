using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double percent = filterFactor * 0.01;
            long filteredPics = (int)(Math.Ceiling(percent * amountPictures));
            long totalFilterTime = amountPictures * filterTime;
            long filteredPicsUploadTime = filteredPics * uploadTime;
            long totalTime = totalFilterTime + filteredPicsUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            string result = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);

            Console.WriteLine(result);
        }
    }
}
