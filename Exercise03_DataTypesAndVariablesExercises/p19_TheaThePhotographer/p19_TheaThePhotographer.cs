using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p19_TheaThePhotographer
{
    class p19_TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long numOfPictures = long.Parse(Console.ReadLine());
            long secPerPicture = long.Parse(Console.ReadLine());
            long filterPercent = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());
            
            long filterSec = numOfPictures * secPerPicture;
            long filteredPictures = (long)Math.Ceiling(numOfPictures * filterPercent / 100.0);
            long uploadSec = filteredPictures * uploadTimePerPicture;
            
            long totalSec = filterSec + uploadSec;

            TimeSpan time = TimeSpan.FromSeconds(totalSec);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
            
        }
    }
}
