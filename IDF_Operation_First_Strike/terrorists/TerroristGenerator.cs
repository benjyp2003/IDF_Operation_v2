using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal static class TerroristGenerator
    {

        public static string GetRandomName() => TerroristsNames.GetRandomName();

        public static int GetRandomRank() => GetRandomNumber.Rand.Next(1, 6); // דרגה רנדומלית 1 - 5

        public static List<string> GetWeaponsList() => Weapons.GetWeapons();

        public static Terrorist GetTerrorist()
        {
            return new Terrorist(GetRandomName(), GetRandomRank(), GetWeaponsList());
        }

        //gets a number and generates terrorists as many as the number givin. 
        public static void GenerateNumberOfTerrorists(int num)
        {
            Console.WriteLine("Initializing Hamas with terrorists...");
            for (int i = 0; i < num; i++)
            {
                Terrorist terrorist = TerroristGenerator.GetTerrorist();
                Hamas.AddTerrorostToHamas(terrorist);
                Console.WriteLine($"Added terrorist {i + 1}: {terrorist.Name} (Rank: {terrorist.Rank})");
            }
            Console.WriteLine($"Total terrorists in Hamas: {Hamas.TerroristsList.Count}\n");
        }
    }



}
