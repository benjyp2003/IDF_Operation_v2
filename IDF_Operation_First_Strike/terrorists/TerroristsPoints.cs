using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class TerroristsPoints
    {
        // static dict with all the terrorists points
        public static Dictionary<Terrorist, int> terroristsPoints = new Dictionary<Terrorist, int>();


        public static void AddToTerroristsPoints(Dictionary<Terrorist, string> RawterroristsList)
        {
            if (RawterroristsList == null || RawterroristsList.Count == 0)
            {
                Console.WriteLine("Warning: No terrorists to process.");
                return;
            }

            foreach (var kvp in RawterroristsList)
            {
                if (kvp.Key == null)
                {
                    Console.WriteLine("Warning: Skipping null terrorist reference.");
                    continue;
                }

                int points = CalculateTerroristPoints(kvp.Key);
                if (terroristsPoints.ContainsKey(kvp.Key))
                {
                    int oldPoints = terroristsPoints[kvp.Key];
                    terroristsPoints[kvp.Key] = points;
                    Console.WriteLine($"Updated points for {kvp.Key.Name}: {oldPoints} -> {points}");
                }
                else
                {
                    terroristsPoints.Add(kvp.Key, points);
                    Console.WriteLine($"Added new terrorist {kvp.Key.Name} with {points} points");
                }
            }
        }

        private static int CalculateTerroristPoints(Terrorist terrorist)
        {
            int rankPoints = terrorist.Rank;
            int weaponPoints = WeaponsPoints.GetWeaponsPoints(terrorist);
            int totalPoints = rankPoints * weaponPoints;

            //Console.WriteLine($"Calculating points for {terrorist.Name}:");
            //Console.WriteLine($"- Rank points: {rankPoints}");
            //Console.WriteLine($"- Weapon points: {weaponPoints}");
            //Console.WriteLine($"- Total points: {totalPoints}");

            return totalPoints;
        }

        public static void ClearPoints()
        {
            terroristsPoints.Clear();
            Console.WriteLine("Terrorist points have been reset.");
        }
    }
}
