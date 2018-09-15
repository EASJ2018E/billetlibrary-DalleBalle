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

        public abstract decimal Pris();
        public abstract string Køretøj();

        public decimal BrobizzRabatPris(decimal pris)
        {
            if (Brobizz)
            {
                decimal rabat = pris * (decimal) 0.05;
                return pris - rabat;
            }

            return pris;
        }
    }
}
