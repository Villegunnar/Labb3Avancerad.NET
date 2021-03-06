using System;
using System.Collections.Generic;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Ford : Cars
    {
        public static bool FordFinish = false;
        public Ford()
        {
            this.Log = new List<string>();
            this.cartype = "Ford";
         
        }

        //The racing loop for Ford, when finnished looping adds winning result to the log.
        public void racing()
        {
            for (decimal Distans = 0.00m; Distans <= raceDistance; Distans++)
            {
                if (emptyTank)
                {
                    Thread.Sleep(30000);
                    emptyTank = false;
                }
                if (tireChange)
                {
                    Thread.Sleep(20000);
                    tireChange = false;
                }
                if (windshieldWash)
                {
                    Thread.Sleep(10000);
                    windshieldWash = false;
                }
                Thread.Sleep(speed);
                distance = Distans;
            }
            FordFinish = true;
            if (!Tesla.TeslaFinish && !Audi.AudiFinish && !Mercedes.MercedesFinish)
            {
                Log.Add($"{DateTime.Now.ToShortTimeString()} " + cartype + " Vann!");
            }
            else
            {
                Log.Add($"{DateTime.Now.ToShortTimeString()} " + cartype + " Gick i mål!");
            }
        }
        
    }
}
