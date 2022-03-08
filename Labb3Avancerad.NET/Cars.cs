using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Cars
    {

        public bool Finish = false;
        public int speed = 60;
        public int displaySpeed = 60;
        public decimal distance = 0.00m;      
        protected bool emptyTank = false;
        protected bool tireChange = false;
        protected bool windshieldWash = false;
        public string cartype;
        public static int raceDistance = 400;
        public List<string> Log { get; set; }

        public void SlutPåBensin(Cars c)
        {
            int speed1;
            Random random1 = new Random();
            if (random1.Next(1, 51) == 40)
            {

                emptyTank = true;
                c.Log.Add("Bensinen tog slut, bilen tankar i 30 sekunder");
                speed1 = c.displaySpeed;
                c.displaySpeed = 0;
                Thread.Sleep(30000);
                c.displaySpeed = speed1;
            }
        }
        public void Punktering(Cars c)
        {
            int speed2;
            Random random1 = new Random();
            if (random1.Next(1, 26) == 25)
            {
                tireChange = true;
                c.Log.Add("Behöver byta däck, stannar 20 sekunder");
                speed2 = c.displaySpeed;
                c.displaySpeed = 0;
                Thread.Sleep(20000);
                c.displaySpeed = speed2;

            }
        }
        public void FågelPåVindrutan(Cars c)
        {
            int speed3;
            Random random1 = new Random();
            if (random1.Next(1, 11) == 5)
            {
                windshieldWash = true;
                c.Log.Add("Behöver tvätta vindrutan, stannar 10 sekunder");
                speed3 = c.displaySpeed;
                c.displaySpeed = 0;
                Thread.Sleep(10000);
                c.displaySpeed = speed3;
            }
        }
        public void Motorfel(Cars c)
        {
            Random random1 = new Random();
            if (random1.Next(1, 6) == 5)
            {
                c.Log.Add("Hastigheten på bilen sänks med 1km/h");
                c.speed = c.speed + 1;
                c.displaySpeed = c.displaySpeed - 1;
            }
        }
        public static void PrintRace(Cars t, Cars f, Cars a)
        {
            while (!(Tesla.TeslaFinish && Ford.FordFinish && Audi.AudiFinish))
            {
                Thread.Sleep(150);

                Console.Clear();
                Console.WriteLine("        Teslan har åkt " + t.distance + " km  hastighet" + t.displaySpeed +
         "km/h                          Audin har åkt " + a.distance + " km  hastighet" + a.displaySpeed +
         "km/h                               Forden har åkt " + f.distance + " km  hastighet" + f.displaySpeed + " km/h \n");

                if (t.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in t.Log)
                    {
                        i++;
                        Console.SetCursorPosition(2, 2 + i);
                        Console.WriteLine(t.cartype + " logg: " + item);
                    }
                }
                if (a.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in a.Log)
                    {
                        i++;
                        Console.SetCursorPosition(68, 2 + i);
                        Console.WriteLine(a.cartype + " logg: " + item);
                    }
                }
                if (f.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in f.Log)
                    {
                        i++;
                        Console.SetCursorPosition(138, 2 + i);
                        Console.WriteLine(f.cartype + " logg: " + item);
                    }
                }
            }
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("Racet är avslutat!");
            Console.ReadLine();
        }
        public void CarError(Cars c)
        {
            while (!c.Finish)
            {
                Thread.Sleep(10000);
                Random random3 = new Random();
                int randomNumber = random3.Next(1, 5);

                if (randomNumber == 1)
                {
                    SlutPåBensin(c);
                }
                if (randomNumber == 2)
                {
                    Punktering(c);
                }
                if (randomNumber == 3)
                {
                    FågelPåVindrutan(c);
                }
                if (randomNumber == 4)
                {
                    Motorfel(c);
                }
            }
        }

        public static void runProgram()
        {
            Console.SetWindowSize(195, 40);
    
            Tesla myTesla = new Tesla();
            Ford myFord = new Ford();
            Audi myAudi = new Audi();

            Thread thread1 = new Thread(myTesla.racing);
            Thread thread2 = new Thread(myFord.racing);
            Thread thread3 = new Thread(myAudi.racing);


            Thread thread4 = new Thread(() => myTesla.CarError(myTesla));
            Thread thread5 = new Thread(() => myFord.CarError(myFord));
            Thread thread6 = new Thread(() => myAudi.CarError(myAudi));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();

            Cars.PrintRace(myTesla, myFord, myAudi);
        }
    }
}
