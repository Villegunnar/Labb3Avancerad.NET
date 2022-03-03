using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Tesla : Cars
    {
        public int speed = 1000;


        public void racing()
        {

            int actualSpeed = speed;
            int displaySpeed = speed;
            int time = 0;

            for (int distans = 0; distans < 10000; distans++)
            {
                Console.WriteLine("Time: " + time++ +" seconds");
                Console.WriteLine("The Tesla has traveled: " + distans.ToString() + "km");

                DateTime myTime = DateTime.Now;

                Console.WriteLine(myTime);
                


                Random random3 = new Random();
                int randomNumber = random3.Next(1, 5);
                if (time == 30000)
                {


                    if (randomNumber == 1)
                    {
                        SlutPåBensin();
                    }
                    if (randomNumber == 2)
                    {
                        Punktering();
                    }
                    if (randomNumber == 3)
                    {
                        FågelPåVindrutan();
                    }
                    if (randomNumber == 4)
                    {
                        if (Motorfel())
                        {
                            actualSpeed += 1;
                            displaySpeed -= 1;
                        }
                    }
                }


                Thread.Sleep(actualSpeed);
                Console.WriteLine("sleep int = " + actualSpeed);
                Console.WriteLine($"Current speed: " + displaySpeed);
            }
        }

    }
}
