using Mamaosem.Utils;
using MamaOsem.CakeLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaOsem.HouseCakeLine
{
    public class MainStationHendler:HouseCakeLineSatationChainBase
    {
        private HouseCakeLineSatationChainBase mainLine;
        public MainStationHendler()
        {
            mainLine = new WeightBigEnoughStation();
            HouseCakeLineSatationChainBase last = new LastStation();

            mainLine.SetNext(last);
        }

        public override bool Act(HouseCake cake)
        {
            return mainLine.Act(cake);
        }
    }
}
