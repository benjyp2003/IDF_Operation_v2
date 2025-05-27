using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class AmanTerroristsReports
    {
        public static Dictionary<DateTime, Dictionary<Terrorist, string>> TerroristsReports = new Dictionary<DateTime, Dictionary<Terrorist, string>>();                                                                               
        public static Dictionary<Terrorist, string> RawTerroristsReports = new Dictionary<Terrorist, string>();

        public static void AddToTerroristsReports(DateTime creationDate, Terrorist terrorist, string lastLocation)
        {
            // Add to the time-based reports
            if (!TerroristsReports.ContainsKey(creationDate))
            {
                TerroristsReports[creationDate] = new Dictionary<Terrorist, string>();
            }
            TerroristsReports[creationDate][terrorist] = lastLocation;

            // Update or add to the raw reports
            if (RawTerroristsReports.ContainsKey(terrorist))
            {
                RawTerroristsReports[terrorist] = lastLocation;
            }
            else
            {
                RawTerroristsReports.Add(terrorist, lastLocation);
            }
        }
    }
}
