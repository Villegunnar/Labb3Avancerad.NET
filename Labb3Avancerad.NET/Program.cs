using System;
using System.Threading;

namespace Labb3Avancerad.NET
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myTime = DateTime.Now;

            Console.WriteLine(myTime);



            Tesla myTesla = new Tesla();
            Ford myFord = new Ford();

            myTesla.racing();
            


            Thread thread1 = new Thread(myTesla.racing);

            Thread thread2 = new Thread(myFord.racing);
            thread1.Start();
        }
    }
}
