using Mamaosem.Utils;
using MamaOsem.HouseCakeLine;
using System;

namespace MamaOsem
{
    class Program
    {
        static void Main(string[] args)
        {
            MainStationHendler lineHendler = new MainStationHendler();
            HouseCake cake1 = new HouseCake();
            cake1.SerialNumber = new uint();
            cake1.Type = CakeType.ChocoVanilla;
            cake1.Weight = 6;
            HouseCake cake2 = new HouseCake();
            cake2.SerialNumber = new uint();
            cake2.Type = CakeType.ChocoVanilla;
            cake2.Weight = 3;
            lineHendler.Act(cake1);
            lineHendler.Act(cake2);
        }
    }
}
