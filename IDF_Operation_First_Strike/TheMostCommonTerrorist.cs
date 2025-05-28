using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class TheMostCommonTerrorist
    {

        Terrorist Common;
        Terrorist Uncommon;

        int CommonNum = 0;
        int UncommonNum = 0;

        int i = 0;

        public Terrorist MostCommonTerrorist()
        {
            foreach (var kvp in AmanTerroristsReports.TerroristsReports)
            {
                if (i == 0)
                {
                    Common = kvp.Value.Keys.FirstOrDefault();
                }

                if (UncommonNum > CommonNum)
                {
                    Common = Uncommon;
                    CommonNum = UncommonNum;
                }

                else
                {
                    CommonNum = 0;
                }

                Uncommon = kvp.Value.Keys.FirstOrDefault();
                UncommonNum = 0;

                foreach (var kvp2 in AmanTerroristsReports.TerroristsReports)
                {
                    if (Common == kvp2.Value.Keys.FirstOrDefault())
                    {
                        CommonNum++;
                    }

                    if (i == 1)
                    {
                        Uncommon = kvp2.Value.Keys.FirstOrDefault();
                    }

                    if (Uncommon == kvp2.Value.Keys.FirstOrDefault())
                    {
                        UncommonNum++;
                    }

                    i++;
                }
            }

            return Common;
        }
    }
}
