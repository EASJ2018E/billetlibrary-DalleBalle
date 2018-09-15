using System;

namespace BilletOpg
{
    public class Bil : KøretøjKlasse
    {
        public Bil(string nummerplade, DateTime dato, bool brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public override decimal Pris()
        {
            return BrobizzRabatPris(240);
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
