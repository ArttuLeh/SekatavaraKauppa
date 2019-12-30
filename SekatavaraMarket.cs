using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekatavaraKauppa2
{
    class SekatavaraMarket : Dictionary<string, Tuote>, IYhteisetRajapinnat
    {
        private string kuvaus;
        private string koodi;
        private double hinta;
        private string tekija;
        private string esittaja;
        private string saveltaja;
        private string sanoittaja;
        Tuote kirja = new Kirja();
        Tuote aanite = new Aanite();
        Dictionary<string, Tuote> dic = new Dictionary<string, Tuote>();

        public Dictionary<string, Tuote> Hae(string t)
        {
            Console.Write("Anna haettavan tuotteen koodi: ");
            t = Console.ReadLine();

            if (dic.TryGetValue(t, out kirja))
            {
                Console.WriteLine(kirja);
            }
            else if (dic.TryGetValue(t, out aanite))
            {
                Console.WriteLine(aanite);
            }
            else
            {
                Console.WriteLine("Tuotetta ei löytynyt!");
            }
            return dic;
        }
        public Dictionary<string, Tuote> Poista(string r)
        {
            Console.Write("Anna poistettavan tuotteen koodi: ");
            r = Console.ReadLine();
            if (dic.TryGetValue(r, out kirja))
            {
                dic.Remove(r);
            }
            else if (dic.TryGetValue(r, out aanite))
            {
                dic.Remove(r);
            }
            return dic;
        }
        public override string ToString()
        {
            foreach (KeyValuePair<string, Tuote> kirjaKeyValuePair in dic)
            {
                Console.WriteLine(kirjaKeyValuePair.Value);
            }
            return string.Format("{0}", dic);
        }
        public void Kysy()
        {
            Console.Write("Lisäätkö kirjan (k) vai äänitteen (ä)? ");
            string valinta2 = Console.ReadLine();
            if (valinta2 == "k")
            {
                Console.Write("Anna kirjan tekijä: ");
                tekija = Console.ReadLine();
                Console.Write("Anna kirjan nimi: ");
                kuvaus = Console.ReadLine();
                Console.Write("Anna kirjan koodi: ");
                koodi = Console.ReadLine();
                Console.Write("Anna kirjan hinta: ");
                string syote = Console.ReadLine();
                double.TryParse(syote, out hinta);
                Tuote kirja = new Kirja(tekija, koodi, hinta, kuvaus);
                //kirja.Kysy();
                dic.Add(kirja.Koodi, kirja);
            }
            else
            {
                Console.Write("Anna äänitteen esittäjä: ");
                esittaja = Console.ReadLine();
                Console.Write("Anna äänitteen nimi: ");
                kuvaus = Console.ReadLine();
                Console.Write("Anna äänitteen sanoittaja: ");
                sanoittaja = Console.ReadLine();
                Console.Write("Anna äänitteen säveltäjä: ");
                saveltaja = Console.ReadLine();
                Console.Write("Anna äänitteen koodi: ");
                koodi = Console.ReadLine();
                Console.Write("Anna äänitteen hinta: ");
                string syote = Console.ReadLine();
                double.TryParse(syote, out hinta);
                Tuote aanite = new Aanite(kuvaus, koodi, hinta, esittaja, saveltaja, sanoittaja);
                //aanite.Kysy();
                dic.Add(aanite.Koodi, aanite);
            }
            
        }
    }
}
