using IDF_Operation_First_Strike.strikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class CommanderMenu
    {
        public static void Show()
        {
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│            Strategic Control Menu             │");
            Console.WriteLine("├───────────────────────────────────────────────┤");
            Console.WriteLine("│ 1 - Get the terrorist with the most intel.    │");
            Console.WriteLine("│ 2 - Show strike units availability & capacity.│");
            Console.WriteLine("│ 3 - Get the most dangerous terrorist.         │");
            Console.WriteLine("│ 4 - Execute a strike.                         │");
            Console.WriteLine("│ 5 - Exit                                      │");
            Console.WriteLine("└───────────────────────────────────────────────┘\n");
            Console.Write("Enter your choice: ");
        }

        public static void HandleChoice()
        {
            bool running = true;
            while (running)
            {
                Show();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Feature not implemented yet.");
                        break;

                    case "2":
                        StrikeUnitsInfo.ShowAvailableUnitsInfo();
                        break;

                    case "3":
                        TerroristsPoints.AddToTerroristsPoints(AmanTerroristsReports.RawTerroristsReports);
                        PreferredTarget.ShowMostDangerousTerroristInfo();
                        break;

                    case "4":
                        TerroristsPoints.AddToTerroristsPoints(AmanTerroristsReports.RawTerroristsReports);
                        var preferredTarget = PreferredTarget.GetpreferredTarget();
                        if (preferredTarget.Count == 0)
                        {
                            Console.WriteLine("No terrorists available for targeting.");
                            break;
                        }
                        Terrorist mostDangerousTerrorist = preferredTarget.Keys.First();
                        StrikeExecution strikeExecution = new StrikeExecution();
                        string location = Locations.GetTerroristLocation(mostDangerousTerrorist);
                        if (string.IsNullOrEmpty(location))
                        {
                            Console.WriteLine("No location information available for the target.");
                            break;
                        }
                        StrikeOption releventStrike = strikeExecution.GetRelevantStrikeUnit(location);
                        strikeExecution.Attack(mostDangerousTerrorist, releventStrike);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
        }
    }
}
