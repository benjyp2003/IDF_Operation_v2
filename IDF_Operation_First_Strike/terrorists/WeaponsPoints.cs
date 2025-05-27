using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation_First_Strike;

namespace IDF_Operation_First_Strike
{
    internal class WeaponsPoints
    {
        public static int GetWeaponsPoints(Terrorist Weapons)
        {
            int weaponsPoints = 0;

            foreach (string weapon in Weapons.Weapons)
            {
                switch (weapon)
                {
                    case "knife":
                        weaponsPoints += 1;
                        break;
                    case "gun":
                        weaponsPoints += 2;
                        break;
                    case "AK47":
                        weaponsPoints += 3;
                        break;
                    case "M16":
                        weaponsPoints += 3;
                        break;
                    default:
                        weaponsPoints += 0;
                        break;
                }
            }
            return weaponsPoints;
            
        }
    }
}


