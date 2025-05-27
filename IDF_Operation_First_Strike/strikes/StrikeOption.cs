using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal abstract class StrikeOption
    {
        public abstract string Name { get; }
        public abstract string BombType { get; }
        public abstract int RemainingBombs { get; set; }
        public abstract int FuelSupply { get; set; }
        public abstract string TargetType { get; }


        public override string ToString()
        {
            return $"Unit name: {Name} \n" +
                   $"BombType: {BombType} \n" +
                   $"RemainingBombs {RemainingBombs} \n" +
                   $"FuelSupply: {FuelSupply} \n" +
                   $"TargetType: {TargetType} \n";
        }
    }
}
