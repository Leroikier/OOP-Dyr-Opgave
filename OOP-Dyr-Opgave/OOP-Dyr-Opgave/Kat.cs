using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dyr_Opgave
{
    class Kat : Dyr
    {
        //Metode til og skaffe Dyr //Der overskrives den tomme skabelon fra "Dyr Klassen"
        public override string GetDyr()
        {
            return "Art = " + Art + " | Foder = " + Foder + " | Vægt = " + Vægt + "Kg | Lyd = " + Lyd + "\n";
        }

        //Metode til og udskrive Dyr //Der overskrives den tomme skabelon fra "Dyr Klassen"
        public override string UdskrivDyr()
        {
            return GetDyr();
        }

        //Custom constructor
        public Kat(string a, string f, double v, string l)
        {
            Art = a;
            Foder = f;
            Vægt = v;
            Lyd = l;
        }
    }
}
