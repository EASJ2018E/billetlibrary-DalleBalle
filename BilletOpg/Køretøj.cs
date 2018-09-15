using System;
using System.Collections.Generic;
using System.Text;

namespace BilletOpg
{
    public abstract class KøretøjKlasse
    {
        public string Nummerplade;
        public DateTime Dato;

        public abstract decimal Pris();
        public abstract string Køretøj();

    }
}
