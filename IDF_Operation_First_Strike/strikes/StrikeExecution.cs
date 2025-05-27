using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{

    internal class StrikeExecution
    {
        static string OperatorName = "officer Benjy and officer oryan";

        // Based on the terrorist's location and type, choose an appropriate strike unit

        public StrikeOption GetRelevantStrikeUnit(string lastLocation)
        {
            if (string.IsNullOrEmpty(lastLocation))
            {
                Console.WriteLine("ERROR! no location given.");
                return null;
            }

            // Find the appropriate strike unit from the existing list
            StrikeOption strikeOption = null;
            switch (lastLocation)
            {
                case "at home":
                    strikeOption = IDF.strikeOptionsList.FirstOrDefault(x => x is F16);
                    break;
                case "in a car":
                    strikeOption = IDF.strikeOptionsList.FirstOrDefault(x => x is Hermes460);
                    break;
                case "outside":
                    strikeOption = IDF.strikeOptionsList.FirstOrDefault(x => x is M109);
                    break;
            }

            if (strikeOption == null)
            {
                Console.WriteLine($"ERROR! No suitable strike unit found for location: {lastLocation}");
            }
            else if (strikeOption.RemainingBombs <= 0)
            {
                Console.WriteLine($"WARNING! {strikeOption.Name} has no remaining bombs.");
            }

            return strikeOption;
        }

        public void Attack(Terrorist terrorist, StrikeOption strikeOption)
        {
            if (strikeOption == null)
            {
                Console.WriteLine("Cannot execute attack: No strike unit available.");
                return;
            }

            if (strikeOption.RemainingBombs <= 0)
            {
                Console.WriteLine($"Cannot execute attack: {strikeOption.Name} has no remaining bombs.");
                return;
            }

            if (!terrorist.IsALive)
            {
                Console.WriteLine($"oops, the terrorist {terrorist.Name} is already dead.");
            }
            else
            {
                Console.WriteLine("Attack commited succefully! \n");
                terrorist.IsALive = false;
                strikeOption.RemainingBombs -= 1;
                ShowAttackInfo(terrorist, strikeOption);
            }
        }

        public void ShowAttackInfo(Terrorist terrorist, StrikeOption strikeOption)
        {
            Console.WriteLine($"Attack commited at {DateTime.Now}, \n" +
                              $"on the terrorist {terrorist.Name}, \n" +
                              $"last seen {Locations.GetTerroristLocation(terrorist)} \n" +
                              $"using {strikeOption.Name} strike unit, \n" +
                              $"which has {strikeOption.RemainingBombs} strikes left. \n" +
                              $"operators: {OperatorName}.");
        }
    }
}
