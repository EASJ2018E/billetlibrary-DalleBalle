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

        /// <summary>
        /// Retunerer prisen med brobizz rabat.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            if (Brobizz)
            {
                return BrobizzRabatPris(125);
            }

            return 125;
        }

        /// <summary>
        /// Giver typen af køretøjet
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
