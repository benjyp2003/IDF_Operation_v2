using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class RandomDateTime
    {
        static DateTime Start = new DateTime(1995, 1, 1);
        static Random Gen = new Random();
        static int Range = (DateTime.Today - Start).Days;


        public static DateTime Next()
        {
            return Start.AddDays(Gen.Next(Range)).AddHours(Gen.Next(0, 24)).AddMinutes(Gen.Next(0, 60)).AddSeconds(Gen.Next(0, 60));
        }
    }
}
