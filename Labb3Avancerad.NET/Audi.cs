using System;
using System.Collections.Generic;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Audi : Cars
    {
        public static bool AudiFinish = false;
        public Audi()
        {
            this.Log = new List<string>();
            this.cartype = "Audi";


        }

        //The racing loop for Audi, when finnished looping adds winning result to the log.
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
            AudiFinish = true;
            if (!Ford.FordFinish && !Tesla.TeslaFinish && !Mercedes.MercedesFinish)
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
