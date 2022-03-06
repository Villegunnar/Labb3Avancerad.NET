using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Tesla : Cars
    {
        public static bool TeslaFinish = false;
        public Tesla()
        {
            this.Log = new List<string>();
            this.cartype = "Tesla";
        }
        public void racing()
        {
            for (decimal Distans = 0.00m; Distans <= raceDistance; Distans++)
            {
                if (Error1)
                {
                    Thread.Sleep(30000);
                    Error1 = false;
                }
                if (Error2)
                {
                    Thread.Sleep(20000);
                    Error2 = false;
                }
                if (Error3)
                {
                    Thread.Sleep(10000);
                    Error3 = false;
                }

                Thread.Sleep(speed);
                distance = Distans;
            }

            TeslaFinish = true;
            
        }
        public void CarError()
        {
            while (!TeslaFinish)
            {


                Thread.Sleep(500);
                Random random3 = new Random();
                int randomNumber = random3.Next(1, 5);

                if (randomNumber == 1)
                {
                    SlutPåBensin(Log);
                }
                if (randomNumber == 2)
                {
                    Punktering(Log);
                }
                if (randomNumber == 3)
                {
                    FågelPåVindrutan(Log);
                }
                if (randomNumber == 4)
                {
                    Motorfel(Log);
                }
            }
            Log.Add(cartype + " gick i mål!");
        }



    }
}
