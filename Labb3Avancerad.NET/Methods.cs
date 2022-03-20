using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Avancerad.NET
{
    public class Methods
    {
        public static void runProgram()
        {
            StartMenu();
 
            Tesla myTesla = new Tesla();
            Ford myFord = new Ford();
            Audi myAudi = new Audi();
            Mercedes myMercedes = new Mercedes();

            Thread thread1 = new Thread(myTesla.racing);
            Thread thread2 = new Thread(myFord.racing);
            Thread thread3 = new Thread(myAudi.racing);
            Thread thread4 = new Thread(myMercedes.racing);
            Thread thread5 = new Thread(() => myTesla.CarError(myTesla));
            Thread thread6 = new Thread(() => myFord.CarError(myFord));
            Thread thread7 = new Thread(() => myAudi.CarError(myAudi));
            Thread thread8 = new Thread(() => myMercedes.CarError(myMercedes));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();

            Thread printRace = new Thread(() => Methods.PrintRace(myTesla, myFord, myAudi, myMercedes, GameMode()));
            printRace.Start();
        }
        public static void StartMenu()
        {
            Console.SetWindowSize(60, 10);

            Console.Write("Välkommen till kampen mellan ");
            colourWriteLine("Testla ", "Audi ", "Ford ", "Mercedes", " \n\nVilken bil går i mål först?\n\n" +


                            "1.     * PressEnterMode *\n" +
                            "2.     * ConstantUpdateMode * \n\n" +
                            "Skriv ditt alternativ och tryck enter: ");

            

        }
        public static bool GameMode()
        {

            bool raceMode = false;
            raceMode = Console.ReadLine() == "1";

            Console.SetWindowSize(210, 40);
            return raceMode;
        }
        public static void PrintRace(Cars t, Cars f, Cars a,Cars m, bool slowMode)
        {
            Console.Clear();
            Console.WriteLine("\n\n\nThe race has begun!!!");
            Thread.Sleep(1500);

            while (!(Tesla.TeslaFinish && Ford.FordFinish && Audi.AudiFinish))
            {
                if (slowMode)
                {

                    Console.WriteLine("\n\nPress any key to see current status");
                    Console.ReadLine();
                }

                Thread.Sleep(150);

                Console.Clear();
                colourWriteLine("      Teslan har åkt " + t.distance + " km  hastighet:" + t.displaySpeed + "km/h         ", "Audin har åkt " + a.distance + " km  hastighet:" + a.displaySpeed +"km/h"    , "         Forden har åkt " + f.distance + " km  hastighet:" + f.displaySpeed + " km/h " , "        Mercedes har åkt " + m.distance + " km  hastighet:" + m.displaySpeed + " km/h \n");

                if (t.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in t.Log)
                    {
               
                        i++;
                        Console.SetCursorPosition(1, 2 + i);
                        colourWriteLine(item);
                  
                    }
                    if (slowMode)
                    {
                        t.Log.Clear();
                    }
                }
                if (a.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in a.Log)
                    {
                        i++;
                        Console.SetCursorPosition(53, 2 + i);
                        colourWriteLine("",item,"");
                       
                    }
                    if (slowMode)
                    {
                        a.Log.Clear();
                    }

                }
                if (f.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in f.Log)
                    {
                        i++;
                        Console.SetCursorPosition(105, 2 + i);
                        colourWriteLine("", "",item);
                        
                    }
                    if (slowMode)
                    {
                        f.Log.Clear();
                    }
                }
                if (m.Log.Count > 0)
                {
                    int i = 0;
                    foreach (string item in m.Log)
                    {
                        i++;
                        Console.SetCursorPosition(158, 2 + i);
                        colourWriteLine("", "", "",item);
                        
                    }
                    if (slowMode)
                    {
                        m.Log.Clear();
                    }
                }


            }

            Console.SetCursorPosition(0, 25);
            Console.WriteLine("Racet är avslutat!");
            Console.ReadLine();
        }

        public static void colourWriteLine(string text1 ="", string text2 ="" , string text3 ="", string text4 = "", string text5 = "")
        {

            

            Console.ForegroundColor = (ConsoleColor)10;
            Console.Write(text1);

            Console.ForegroundColor = (ConsoleColor)6;
            Console.Write(text2);

            Console.ForegroundColor = (ConsoleColor)9;
            Console.Write(text3);

            Console.ForegroundColor = (ConsoleColor)14;
            Console.Write(text4);

            Console.ForegroundColor = (ConsoleColor)15;

            Console.Write(text5);


        }
        


  
    }
}
