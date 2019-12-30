using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekatavaraKauppa2
{
    class Aanite : Tuote
    {
        private string esittaja;
        private string saveltaja;
        private string sanoittaja;

        public Aanite() { }
        public Aanite(string kuvaus, string koodi, double hinta, string esittaja, string saveltaja,
            string sanoittaja) : base(kuvaus, koodi, hinta)
        {
            this.esittaja = esittaja;
            this.saveltaja = saveltaja;
            this.sanoittaja = sanoittaja;
        }
        public string Esittja
        {
            get { return esittaja; }
            set { esittaja = value; }
        }
        public string Saveltaja
        {
            get { return saveltaja; }
            set { saveltaja = value; }
        }
        public string Sanoittaja
        {
            get { return sanoittaja; }
            set { sanoittaja = value; }
        }
        public override string ToString()
        {
            return "Äänite - " + esittaja + ": " + kuvaus + ", san " + sanoittaja + ", säv " + saveltaja + ", " + koodi + ", " + hinta + " euroa";
        }
        public override void Kysy()
        {
        }

    }
}
