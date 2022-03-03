using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Ford : Cars
    {
        public int speed = 100;


        public void racing()
        {

            int actualSpeed = speed;
            int displaySpeed = speed;

            for (int distans = 0; distans < 10000; distans++)
            {
                Console.WriteLine("The Tesla has traveled: " + distans.ToString() + "km");

                Random random3 = new Random();

                
                if (random3.Next(1, 5) == 1)
                {
                    SlutPåBensin();
                }
                if (random3.Next(1, 5) == 2)
                {
                    Punktering();
                }
                if (random3.Next(1, 5) == 3)
                {
                    FågelPåVindrutan();
                }
                if (random3.Next(1, 5) == 4)
                {
                    if (Motorfel())
                    {
                        actualSpeed += 1;
                        displaySpeed -= 1;
                    }
                }
           

  
                Thread.Sleep(actualSpeed);
                Console.WriteLine("sleep int = " + actualSpeed);
                Console.WriteLine($"Current speed: " + displaySpeed);
            }
        }
    }
}
