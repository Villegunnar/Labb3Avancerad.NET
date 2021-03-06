using System;
using System.Collections.Generic;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Mercedes : Cars
    {
        public static bool MercedesFinish = false;
        public Mercedes()
        {
            this.Log = new List<string>();
            this.cartype = "Mercedes";
        }

        //The racing loop for Mercedes, when finnished looping adds winning result to the log.
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
            MercedesFinish = true;
            if (!Ford.FordFinish && !Tesla.TeslaFinish && !Audi.AudiFinish)
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
