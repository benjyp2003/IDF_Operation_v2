using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    // Based on the terrorist's location and type, choose an appropriate strike unit

    internal static class StrikeExecution
    {
        static StrikeOption GetRelevantStrikeUnit(string lastLocation)
        {
            // deffult strike is F16
            StrikeOption strikeOption = new F16();
            if (string.IsNullOrEmpty(lastLocation))
            { Console.WriteLine("no location givin "); }

            else if (lastLocation == "at home")
            {
                strikeOption =  new F16();
            }
            else if (lastLocation == "in a car")
            {
                strikeOption =  new Hermes460();
            }
            else if (lastLocation == "outside")
            {
                strikeOption = new M109();
            }

            return strikeOption;
        }
    }
}
