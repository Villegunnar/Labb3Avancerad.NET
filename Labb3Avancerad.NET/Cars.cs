using System;
using System.Collections.Generic;
using System.Threading;

namespace Labb3Avancerad.NET
{
    //Cars class containing properties that are inherted by Adui,Ford,Mercedes and Tesla class.
    public class Cars
    {
        //public bool Finish = false;
        public int speed = 60;
        public int displaySpeed = 60;
        public decimal distance = 0.00m;
        protected bool emptyTank = false;
        protected bool tireChange = false;
        protected bool windshieldWash = false;
        public string cartype;
        public static int raceDistance = 500;
        public List<string> Log { get; set; }



        //The 4 events that may happen in the race to each car.
        public void OutOfGas(Cars c)
        {
            int speed1;
            Random random1 = new Random();
            if (random1.Next(1, 51) == 40)
            {

                
              
                    emptyTank = true;
                    c.Log.Add($"{DateTime.Now.ToShortTimeString()} Bensinen tog slut, bilen tankar i 30 sekunder");
                    speed1 = c.displaySpeed;
                    c.displaySpeed = 0;
                    Thread.Sleep(30000);
                    c.displaySpeed = speed1;
               
                
            }
        }
        public void FlatTire(Cars c)
        {
            int speed2;
            Random random1 = new Random();
            if (random1.Next(1, 26) == 25)
            {
               
                    tireChange = true;
                    c.Log.Add($"{DateTime.Now.ToShortTimeString()} Behöver byta däck, stannar 20 sekunder");
                    speed2 = c.displaySpeed;
                    c.displaySpeed = 0;
                    Thread.Sleep(20000);
                    c.displaySpeed = speed2;
               
               

            }
        }
        public void BirdOnWindShield(Cars c)
        {
            int speed3;
            Random random1 = new Random();
            if (random1.Next(1, 11) == 5)
            {
                
                    windshieldWash = true;
                    c.Log.Add($"{DateTime.Now.ToShortTimeString()} Behöver tvätta vindrutan, stannar 10 sekunder");
                    speed3 = c.displaySpeed;
                    c.displaySpeed = 0;
                    Thread.Sleep(10000);
                    c.displaySpeed = speed3;
                
            }
        }
        public void EngineFailure(Cars c)
        {
           
                Random random1 = new Random();
                if (random1.Next(1, 6) == 5)
                {
                    c.Log.Add($"{DateTime.Now.ToShortTimeString()} Hastigheten på bilen sänks med 1km/h");
                    c.speed = c.speed + 1;
                    c.displaySpeed = c.displaySpeed - 1;
                }
            
        }


        // A method with a thread.Sleep for setting the time to which a while loop
        // goes through the events which then by chance may execute.
        public void CarError(Cars c)
        {
            while (!(Tesla.TeslaFinish && Ford.FordFinish && Audi.AudiFinish && Mercedes.MercedesFinish))
            {
                Thread.Sleep(1000);
                Random random3 = new Random();
                int randomNumber = random3.Next(1, 5);

                if (randomNumber == 1)
                {
                    OutOfGas(c);
                }
                if (randomNumber == 2)
                {
                    FlatTire(c);
                }
                if (randomNumber == 3)
                {
                    BirdOnWindShield(c);
                }
                if (randomNumber == 4)
                {
                    EngineFailure(c);
                }
            }
        }

        
    }
}
