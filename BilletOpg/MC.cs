using System;
using System.Collections.Generic;
using System.Text;

namespace BilletOpg
{
    public class MC
    {
        public string Nummerplade;
        public DateTime Dato;

        public MC(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        public decimal Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
