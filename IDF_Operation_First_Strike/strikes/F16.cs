using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class F16 :StrikeOption
    {
        public override string Name { get; } = "F16";
        public override string BombType { get; } = "0.5 - 1 Ton";
        public override int RemainingBombs { get; set; } = 8;
        public override int FuelSupply { get; set;  } = 150;
        public override string TargetType { get; } = "Buildings";

        public string Operator = "pilot";

    }
}
