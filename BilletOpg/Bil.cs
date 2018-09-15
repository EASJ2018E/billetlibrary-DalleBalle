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

        /// <summary>
        /// Giver prisen på køretøjet
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            if (Brobizz)
            {
                return BrobizzRabatPris(240);
            }

            return 240;
        }

        /// <summary>
        /// Giver typen af køretøjet
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
