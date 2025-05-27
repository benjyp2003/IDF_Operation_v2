using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristsNames
    {
        static  string[] FirstNames  = {
                "Ahmad", "Yousef", "Saeed", "Khaled", "Rami",
                "Maher", "Fadi", "Basem", "Nader", "Alaa",
                "Hussein", "Ali", "Wasim", "Mahmoud", "Ibrahim",
                "Tariq", "Jihad", "Samir", "Ammar", "Sharif"
            };

        static string[] LastNames  = {
                "Khalil", "Mansour", "Al-Ali", "Zeidan", "Yousef",
                "Salim", "Darwish", "Radi", "Jaber", "Naim",
                "Barakat", "Omran", "Al-Zahar", "Hijazi", "Kamal",
                "Najm", "Shaaban", "Maqdad", "Abu-Salim", "Qasem"
            };


        public static string GetRandomName() // Returns a list with a random first name and last name
        {
            return FirstNames[GetRandomNumber.Rand.Next(FirstNames.Length)]  + " " + 
                LastNames[GetRandomNumber.Rand.Next(LastNames.Length)];
        }
    }
}
