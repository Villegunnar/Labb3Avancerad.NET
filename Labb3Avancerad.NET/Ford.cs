using System;
using System.Collections.Generic;
using System.Text;
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


            FordFinish = true;
            
        }
        public void CarError()
        {
            while (!FordFinish)
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

            FordFinish = true;
            Log.Add(cartype + " gick i mål!");
        }


    }
}
