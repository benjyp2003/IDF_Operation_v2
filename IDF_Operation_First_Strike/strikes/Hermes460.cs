using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class Hermes460 : StrikeOption
    {
        public override string Name { get; } = "Hermes 460";
        public override string BombType { get; } = "50 - 200 kg";
        public override int RemainingBombs { get; set; } = 3;
        public override int FuelSupply { get; set; } = 50;
        public override string TargetType { get; } = "people, vehicles";
    }
}
