using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dyr_Opgave
{
    abstract class Dyr
    {
        //Variabeler
        public string Art;
        public string Foder;
        public string Lyd;
        public double Vægt;

        //Abstract Getareal
        abstract public string GetDyr();

        //Abstract Udskrivfigur
        abstract public string UdskrivDyr();
    }
}
