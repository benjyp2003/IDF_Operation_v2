using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Weapons
    {
        static string[] weapons = { "knife", "gun", "AK47", "M16" };

        //static Random random = new Random();

        public static List<string> GetWeapons()
        {
            List<string> selectedWeapons = new List<string>();

            //int howMany = random.Next(1, weapons.Length + 1);

            for (int i = 0; i < GetRandomNumber.Rand.Next(0,weapons.Length); i++)
            {
                selectedWeapons.Add(weapons[i]);
            }

            return selectedWeapons;
        }

    }
}
