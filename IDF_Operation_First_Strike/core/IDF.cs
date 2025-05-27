using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class IDF
    {
        public static string DateOfEstablish { get; private set; } = "26/05/1948";
        public static string CurrentCommander { get; private set; } = "Eyal Zamir";

        public static List<StrikeOption> strikeOptionsList = new List<StrikeOption>();

        public static void AddToStrikeList(StrikeOption option)
        {
            strikeOptionsList.Add(option);
        }
    }

}
