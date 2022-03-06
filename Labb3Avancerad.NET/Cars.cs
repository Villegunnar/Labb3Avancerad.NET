using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Cars
    {
        public decimal distance =  0.00m;
        public int speed = 60;
        public int displaySpeed;
        protected bool Error1 = false;
        protected bool Error2 = false;
        protected bool Error3 = false;
        public bool winner = false;
        public string cartype;
        public static int raceDistance = 100;
        public List<string> Log { get; set; }

        public void SlutPåBensin(List<string> Logg)
        {
            Random random1 = new Random();
            if (random1.Next(1, 51) == 40)
            {
                Error1 = true;
                Logg.Add("Bensinen tog slut, bilen tankar i 30 sekunder");
                Thread.Sleep(30000);
                
            }

        }
        public void Punktering(List<string> Logg)
        {
            Random random1 = new Random();
            if (random1.Next(1, 26) == 25)
            {

                Error2 = true;
                Logg.Add("Behöver byta däck, stannar 20 sekunder");
                Thread.Sleep(20000);
            }
        }
        public void FågelPåVindrutan(List<string> Logg)
        {
            Random random1 = new Random();
            if (random1.Next(1, 11) == 5)
            {
                Error3 = true;
                Logg.Add("Behöver tvätta vindrutan, stannar 10 sekunder");
                Thread.Sleep(10000);
              
            }
        }
        public void Motorfel(List<string> Logg)
        {
            Random random1 = new Random();
            if (random1.Next(1, 6) == 5)
            {

                Logg.Add("Hastigheten på bilen sänks med 1km/h");
                speed = speed + 1;

            }

        }

 
        public static void PrintRace(Tesla t, Ford f, Audi a)

        {

            while (!(t.winner && f.winner && a.winner))
            {
                Console.Clear();
                Console.WriteLine("        Teslan har åkt " + t.distance + " km  hastighet" + t.displaySpeed +
         "km/h                          Audin har åkt " + a.distance + " km  hastighet" + t.displaySpeed +
         "km/h                               Forden har åkt " + f.distance + " km  hastighet" + t.displaySpeed + " km/h \n");

                if (t.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in t.Log)
                    {

                        i++;

                        Console.SetCursorPosition(2, 2 + i);
                        Console.WriteLine("Teslans Logg: " + item);

                    }
                }

                if (a.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in a.Log)
                    {
                        i++;
                        Console.SetCursorPosition(68, 2 + i);
                        Console.WriteLine("Audins Logg: " + item);


                    }
                }


                if (f.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in f.Log)
                    {
                        i++;
                        Console.SetCursorPosition(135, 2 + i);
                        Console.WriteLine("Fordens Logg: " + item);


                    }
                }

                Thread.Sleep(200);
            }
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("Racet är avslutat!");
            Console.ReadLine();

        }

    }
}
