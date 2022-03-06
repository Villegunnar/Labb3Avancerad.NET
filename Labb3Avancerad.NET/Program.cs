using System;
using System.Threading;

namespace Labb3Avancerad.NET
{

    class Program
    {

        static void rankPlacements()
        {

        




        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(195, 40);
            Tesla myTesla = new Tesla();
            Ford myFord = new Ford();
            Audi myAudi = new Audi();
      


            Thread thread1 = new Thread(myTesla.racing);
            Thread thread2 = new Thread(myFord.racing);
            Thread thread3 = new Thread(myAudi.racing);
            Thread thread4 = new Thread(myTesla.CarError);
            Thread thread5 = new Thread(myFord.CarError);
            Thread thread6 = new Thread(myAudi.CarError);
           

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            
            Cars.PrintRace(myTesla, myFord, myAudi);
            //Cars.TheWinner(myTesla, myFord, myAudi);






        }
    }
}
