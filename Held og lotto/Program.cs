using System;
using System.Threading;

namespace Held_og_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Random rng = new Random();


            //
            string text = "";

            //
            for (int i = 0; i < 7; i++)
            {
                wait(2);
                int roll = rng.Next(1, 37);
                if (i < 6)
                {
                    Console.Write($"{roll}  ", Task.Delay(20000));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{roll}  ", Task.Delay(2000));
                }
            }

            void wait(double x)
            {
                DateTime t = DateTime.Now;
                DateTime tf = DateTime.Now.AddSeconds(x);

                while (t < tf)
                {
                    t = DateTime.Now;
                }
            }



            Console.Read();
        }
    }
}