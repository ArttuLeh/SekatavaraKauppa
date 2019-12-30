using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekatavaraKauppa2
{
    public abstract class Tuote : IYhteisetRajapinnat
    {
        protected string kuvaus;
        protected string koodi;
        protected double hinta;

        public Tuote() { }

        public Tuote(string kuvaus, string koodi, double hinta)
        {
            this.kuvaus = kuvaus;
            this.koodi = koodi;
            this.hinta = hinta;
        }
        public string Koodi
        {
            get { return koodi; }
            set { koodi = value; }
        }
        public string Kuvaus
        {
            get { return kuvaus; }
            set { kuvaus = value; }
        }
        public double Hinta
        {
            get { return hinta; }
            set { hinta = value; }
        }

        public abstract override string ToString();
        public abstract void Kysy();
    }
}

