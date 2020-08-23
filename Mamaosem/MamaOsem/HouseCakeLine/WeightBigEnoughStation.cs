using Mamaosem.Utils;
using MamaOsem.CakeLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaOsem.HouseCakeLine
{
    public class WeightBigEnoughStation : HouseCakeLineSatationChainBase
    {
        public override bool Act(HouseCake cake)
        {
            if (cake.Weight < 4)
            {
                cake.Weight = 4;
            }
            return true && (_nextStation?.Act(cake) ?? true);
        }
    }
}
