using System;
using System.Collections.Generic;
using System.Text;

namespace BilletOpg
{
    public class MC : KøretøjKlasse
    {
        public MC(string nummerplade, DateTime dato, bool brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public override decimal Pris()
        {
            return BrobizzRabatPris(125);
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
