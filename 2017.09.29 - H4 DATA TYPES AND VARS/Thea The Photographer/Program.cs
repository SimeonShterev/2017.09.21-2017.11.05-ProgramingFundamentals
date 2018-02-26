using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long timeToFilterSinglePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long timeToUploadSinglePicture = long.Parse(Console.ReadLine());
            double filteredPictures = filterFactor * picturesTaken / 100.0;
            long timeTouploadAllPictures = timeToUploadSinglePicture * (long)Math.Ceiling(filteredPictures);
            long seconds = 0;
            long minutes = 0;
            long hours = 0;
            long days = 0;
            long totalTimeInSeconds = picturesTaken * timeToFilterSinglePicture + timeTouploadAllPictures;
            if (totalTimeInSeconds>59)
            {
                minutes = (long) totalTimeInSeconds / 60;
                seconds = (long) totalTimeInSeconds % 60;
            }
            if (minutes >59)
            {
                hours = minutes / 60;
                minutes = minutes % 60;
            }
            if (hours>23)
            {
                days = hours / 24;
                hours = hours % 24;
            }
            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

          // TimeSpan span = TimeSpan.FromSeconds(totalTimeInSeconds);
          // string formatedTime = span.ToString(@"d\:hh\:mm\:ss");
          // Console.WriteLine(formatedTime);
        }
    }
}
