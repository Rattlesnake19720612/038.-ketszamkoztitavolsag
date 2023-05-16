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

/*Ez a C# program kiszámítja két szám közötti távolságot. A felhasználótól bekéri a két számot, majd a Math.Abs() függvény segítségével kiszámítja a számok abszolút értékét, majd elmenti a távolságot egy double típusú változóba. Végül kiírja a távolságot a konzolra a Console.WriteLine() függvénnyel. A program végén a Console.ReadKey() függvény segítségével várakozik a felhasználó bemenetére, mielőtt bezáródna.*/
