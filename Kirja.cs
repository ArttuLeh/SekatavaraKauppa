using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekatavaraKauppa2
{
    class Kirja : Tuote
    {
        private string tekija;

        public Kirja() { }
        public Kirja(string kuvaus, string koodi, double hinta, string tekija) :
            base(kuvaus, koodi, hinta)
        {
            this.tekija = tekija;
        }
        public string Tekija
        {
            get { return tekija; }
            set { tekija = value; }
        }
        public override string ToString()
        {
            return "Kirja - " + kuvaus + ": " + tekija + ", " + koodi + ", " + hinta + " euroa";
        }
        public override void Kysy()
        {
            //Console.Write("Anna kirjan tekijä: ");
            //tekija = Console.ReadLine();
            //Console.Write("Anna kirjan nimi: ");
            //kuvaus = Console.ReadLine();
            //Console.Write("Anna kirjan koodi: ");
            //koodi = Console.ReadLine();
            //Console.Write("Anna kirjan hinta: ");
            //string syote = Console.ReadLine();
            //double.TryParse(syote, out hinta);
            //new Kirja(tekija, koodi, hinta, kuvaus);

        }
    }
}
