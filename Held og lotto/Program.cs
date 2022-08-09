using System;
using System.Threading;

namespace Held_og_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generator of random numbers
            Random rng = new Random();


            //A string to store the text later on
            string text = "";
            
            //a for loop that runs 7 times, with the last number being red.
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

            //makeshift timer
            void wait(double x)
            {
                DateTime t = DateTime.Now;
                DateTime tf = DateTime.Now.AddSeconds(x);

                while (t < tf)
                {
                    t = DateTime.Now;
                }
            }


            //TO NOT close console yet
            Console.Read();
        }
    }
}