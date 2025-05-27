using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike.strikes
{
    internal static class StrikeUnitsInfo
    {
        public static List<StrikeOption> GetAvailableStrikeUnits()
        {
            return IDF.strikeOptionsList;
        }
        
        public static void ShowAvailableUnitsInfo()
        {
            List<StrikeOption> strikeOptions = GetAvailableStrikeUnits();
            foreach (StrikeOption unit in strikeOptions)
            {
                if (unit.RemainingBombs > 0)
                { Console.WriteLine(unit); } 
            }
        }

        public static int GetRemainingStrikes(StrikeOption unit)
        {
            return unit.RemainingBombs;
        }

        public static int GetRemainingFuel(StrikeOption unit)
        {
            return unit.FuelSupply;
        }
    }
}
