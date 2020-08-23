using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mamaosem.Utils;

namespace MamaOsem.CakeLine
{
    public class LastStation : HouseCakeLineSatationChainBase
    {
        public override bool Act(HouseCake cake)
        {

            string path = @"..\..\..\storage\storage.storage";
            cake.ProductionTime = DateTime.Now;
            cake.ExpiryDate = DateTime.Now.AddDays(30);
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("create");
   
                    sw.WriteLine($"cake serial num {cake.SerialNumber} type {cake.Type} weight : {cake.Weight} good until {cake.ExpiryDate} and make in {cake.ProductionTime}");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("append");
                    sw.WriteLine($"cake serial num {cake.SerialNumber} type {cake.Type} weight : {cake.Weight} good until {cake.ExpiryDate} and make in {cake.ProductionTime}");
                }
            }
            return true && (_nextStation?.Act(cake) ?? true);
        }
    }
}
