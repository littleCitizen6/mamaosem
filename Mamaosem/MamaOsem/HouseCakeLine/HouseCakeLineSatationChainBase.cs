using System;
using System.Collections.Generic;
using System.Text;
using Mamaosem.Utils;

namespace MamaOsem.CakeLine
{
    public abstract class HouseCakeLineSatationChainBase
    {
        protected HouseCakeLineSatationChainBase _nextStation;
        public HouseCakeLineSatationChainBase SetNext(HouseCakeLineSatationChainBase station)
        {
            if (_nextStation == null)
            {
                _nextStation = station;
            }
            else
            {
                _nextStation.SetNext(station);
            }

            return this;
        }
    public abstract bool Act(HouseCake cake);
    
    }
}
