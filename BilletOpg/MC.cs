using System;
using System.Collections.Generic;
using System.Text;

namespace BilletOpg
{
    public class MC : KøretøjKlasse
    {
        public MC(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
