using System;

namespace BilletOpg
{
    public class Bil
    {
        public string Nummerplade;
        public DateTime Dato;

        public Bil(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        public decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
