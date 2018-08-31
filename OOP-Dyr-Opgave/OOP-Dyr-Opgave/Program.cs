using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dyr_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Dyrelisten\n");
            //Opretter en liste til og sætte figurer ind
            List<Dyr> Dyreliste = new List<Dyr>();
            Dyreliste.Add(new Elefant("Elefant", "Hø", 1200, "Trutter"));
            Dyreliste.Add(new Kat("Kat", "Fisk", 5, "Miawer"));
            Dyreliste.Add(new Hund("Hund", "Kød", 24, "Wuf Wuf"));

            //For hver linjie i listen udskriver den hvad der står på linjien
            foreach (var a in Dyreliste)
            {
                Console.WriteLine(a.UdskrivDyr());
            }

            //Slut
            Console.ReadKey();
        }
    }
}
