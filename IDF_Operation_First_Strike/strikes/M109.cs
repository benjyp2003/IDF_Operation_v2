using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class M109 : StrikeOption
    {
        public override string Name { get; } = "M109";
        public override string BombType { get; } = "5 - 25 kg";
        public override int RemainingBombs { get; set; } = 40;
        public override int FuelSupply { get; set; } = 350;
        public override string TargetType { get; } = "open area";
    }
}
