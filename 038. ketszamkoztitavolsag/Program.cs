using System;

namespace _038.ketszamkoztitavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            double tavolsag = Math.Abs(szam1 - szam2);

            Console.Write("A két szám közti távolság: " + tavolsag);

            Console.ReadKey();    
        }
    }
}
