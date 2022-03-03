using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public abstract class Cars 
    {

        
        public void SlutPåBensin()
        {

            Random random1 = new Random();
            if (random1.Next(1, 51) == 40)
            {
                Console.WriteLine("Bensinen tog slut, bilen tankar i 30 sekunder....");
                Thread.Sleep(30000);
            }

        }
        public void Punktering()
        {
            Random random1 = new Random();
            if (random1.Next(1, 26) == 25)
            {
                Console.WriteLine("Behöver byta däck, stannar 20 sekunder");
                Thread.Sleep(20000);
            }
        }
        public void FågelPåVindrutan()
        {
            Random random1 = new Random();
            if (random1.Next(1, 11) == 5)
            {
                Console.WriteLine("Behöver tvätta vindrutan, stannar 10 sekunder");
                Thread.Sleep(10000);
            }


        }
        public bool Motorfel()
        {
            Random random1 = new Random();
            if (random1.Next(1, 6) == 5)
            {
                Console.WriteLine("Hastigheten på bilen sänks med 1km/h");
                return true;
            }

            return false;
        }
    }
}
