using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class Hamas
    {
        public static string DateOfEstablishment { get; } = "10/12/1987";
        public static string CurrentCommander { get; private set; } = "Izz al-Din al-Haddad";
        
        public static List<Terrorist> TerroristsList = new List<Terrorist>();

        public static void AddTerrorostToHamas(Terrorist terrorist)
        {
            TerroristsList.Add(terrorist);
        }

        public static Terrorist GetTerrorist()
        {
            return TerroristsList[GetRandomNumber.Rand.Next(0, TerroristsList.Count())];
        }

   

    }


}
