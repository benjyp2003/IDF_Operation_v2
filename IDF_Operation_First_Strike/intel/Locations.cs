using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Locations
    {
        public static string[] LocationList = { "at home", "in a car", "outside" };

        public static string GetRandomLocation()
        {
            return LocationList[GetRandomNumber.Rand.Next(LocationList.Length)];
        }

        public static string GetTerroristLocation(Terrorist terrorist)
        {
            if (terrorist == null)
            {
                Console.WriteLine("Error: Invalid terrorist reference.");
                return null;
            }

            if (AmanTerroristsReports.TerroristsReports.Count == 0)
            {
                Console.WriteLine("Error: No location reports available.");
                return null;
            }

            // Get the recent report for this terrorist
            // Step 1: Get all reports
            Dictionary<DateTime, Dictionary<Terrorist, string>> allReports = AmanTerroristsReports.TerroristsReports;
            KeyValuePair<DateTime, Dictionary<Terrorist, string>> mostRecentReport = new KeyValuePair<DateTime, Dictionary<Terrorist, string>>();

            // Step 2: Sort by date descending
            var sortedReports = allReports
                .OrderByDescending(report => report.Key);  

            // Step 3: Find the first report where the terrorist appears
            foreach (var report in sortedReports)
            {
                if (report.Value.ContainsKey(terrorist))
                {
                    mostRecentReport = report; // this is KeyValuePair<DateTime, Dictionary<Terrorist, string>>
                    break;
                }
            }


            if (mostRecentReport.Value != null)
            {
                return mostRecentReport.Value[terrorist];
            }

            Console.WriteLine($"No location found for terrorist: {terrorist.Name}");
            return null;
        }

        public static bool IsValidLocation(string location)
        {
            return !string.IsNullOrEmpty(location) && LocationList.Contains(location);
        }
    }
}

