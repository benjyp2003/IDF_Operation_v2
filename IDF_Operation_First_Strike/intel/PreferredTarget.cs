using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class PreferredTarget
    {
        public static Dictionary<Terrorist, int> GetpreferredTarget()
        {
            Dictionary<Terrorist, int> preferredTarget = new Dictionary<Terrorist, int>();

            Terrorist terrorist = null;
            int points = 0;


            foreach (var member in TerroristsPoints.terroristsPoints)
            {
                if (member.Value > points)
                {
                    points = member.Value;
                    terrorist = member.Key;
                }
            }
            if (terrorist != null)
            { preferredTarget[terrorist] = points; }
            

            return preferredTarget;
        } 
        
        public static void ShowMostDangerousTerroristInfo()
        {
            Dictionary<Terrorist, int> preferredTarget = GetpreferredTarget();
            Console.WriteLine($"most dangerous terrorist that has {preferredTarget[preferredTarget.Keys.FirstOrDefault()]} points is: \n" +
                                            preferredTarget.Keys.FirstOrDefault());
        }
    }   
}
