using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    
    internal class GenerateIntel 
    {

        public  Terrorist terrorist = Hamas.GetTerrorist();

        public  string Location = Locations.GetRandomLocation();

        public  DateTime TimeCollected = RandomDateTime.Next();

        
    }
}
