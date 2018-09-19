using System;
using System.Collections.Generic;
using System.Text;

namespace BilletOpg
{
    public abstract class KøretøjKlasse
    {
        private string _nummerplade;
        public DateTime Dato;
        public bool Brobizz;

        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen har for mange tegn.");
                }
                else
                {
                    _nummerplade = value;
                }
            }
        }

        /// <summary>
        /// Giver prisen til køretøjet
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Giver typen af køretøjet
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();

        /// <summary>
        /// Brobizz Rabat returnere prisen med 5% rabat
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public decimal BrobizzRabatPris(decimal pris)
        {
            //decimal rabat = pris * (decimal) 0.05;
            //return pris - rabat;

            return pris * (decimal)0.95;
        }
    }
}
