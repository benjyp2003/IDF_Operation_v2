using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Aman
    {
        public static Terrorist Terrorist;

        public static string LastLocation;

        public static DateTime TimeCollected;


        public static void CreateAReport()
        {
            Terrorist = new GenerateIntel().terrorist;
            LastLocation = new GenerateIntel().Location;
            TimeCollected = new GenerateIntel().TimeCollected;

            AmanTerroristsReports.AddToTerroristsReports(TimeCollected, Terrorist, LastLocation);
        }

    }
}
