using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("admeg a kinti hőmérsékletet: ");
            int ho = int.Parse(Console.ReadLine());
            if (ho < 0)
            {
                Console.WriteLine("Fagy van odakint");
            }
            else
            {
                Console.WriteLine("nincs fagy odakint");
            }
            //FEladat 17
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Szeretsz programozni?: ");
            string valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                Console.WriteLine("Még sokraviszed az életben");
            }
            else
            {
                Console.WriteLine("Nincs jelentősége hogy élsz-e a jövőben");
            }

            Console.WriteLine("------------------------------------------");
            //feladat 18


            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros! ");
            }
            else
            {
                Console.WriteLine("A szám párartlan! ");
            }

            Console.ReadKey();




        }
    }
}
