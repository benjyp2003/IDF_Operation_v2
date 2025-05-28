using IDF_Operation_First_Strike.strikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("You must pass the API key as a command - line argument");
                return;
            }

            string apiKey = args[0]; // Read the first argument (your API key)
                                     // use the key as a part of the httpClient


            //        // generating 5 - 10 terrorists
            //        int numTerrorists = GetRandomNumber.Rand.Next(5, 11);
            //        TerroristGenerator.GenerateNumberOfTerrorists(numTerrorists);



            //        // Initialize IDF with strike options
            //        Console.WriteLine("Initializing IDF strike units...");
            //        IDF.strikeOptionsList.Add(new F16());
            //        IDF.strikeOptionsList.Add(new Hermes460());
            //        IDF.strikeOptionsList.Add(new M109());
            //        Console.WriteLine("Strike units initialized:\n");
            //        StrikeUnitsInfo.ShowAvailableUnitsInfo();
            //        Console.WriteLine();

            //        // Generate 10-20 random intelligence reports
            //        Console.WriteLine("Generating intelligence reports...");
            //        int numReports = GetRandomNumber.Rand.Next(10, 21);
            //        for (int i = 0; i < numReports; i++)
            //        {
            //            Aman.CreateAReport();
            //            Console.WriteLine($"Report {i + 1}: {Aman.Terrorist.Name} was spotted {Aman.LastLocation} at {Aman.TimeCollected}");
            //        }
            //        Console.WriteLine($"\nTotal intelligence reports generated: {numReports}\n");

            //        // Start the command menu
            //        Console.WriteLine("Initialization complete. Starting command menu...\n");
            //        CommanderMenu.HandleChoice();


        }
    }
}
