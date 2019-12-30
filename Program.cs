using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Määrittele rajapinta YhteisetRajapinnat joka sisältäää metodimäärittelyt string ToString() sekä void Kysy().
 * Rajapinnat toteuttavissa luokissa ToString-metodilla palautetaan merkkijonossa olion sisältö konsolille
 * tulostettavassa muodossa ja Kysy-metodilla kysytään konsolilta olion ominaisuudet.

Määrittele abtraksi luokka Tuote, jota on tarkoitus käyttää periytymisessä kantaluokkana.
Tuote-luokka toteuttaa rajapinnan YhteisetRajapinnat. Tuote-luokka sisältää jäsenmuuttujat koodi,
kuvaus ja hinta sekä niille määritellyt vastaavat aksessorit. Määrittele luokalle myös muodostin ja  alustava muodostin,
jolla alustetaan jäsenmuuttujat.

Määrittele tämän jälkeen kaksi uutta luokkaa, joiden kantaluokkana on Tuote-luokka.
Nämä uudet luokat ovat Kirja ja Aanite. Kirja-luokalle määritellään lisäjäseneksi tekijä ja sille aksessori sekä
Aanite-luokalle määritellään esittaja, saveltaja, sanoittaja ja sovittaja aksessoreineen.
Määrittele Kirja ja Aanite -luokille muodostimet sekää rajapintamäärittelyn vaatimat metodit.

Määrittele luokka SekatavaraMarket, joka perii Dictionary<string,
Tuote>-säiliöluokan sekä toteuttaa rajapinnan YhteisetRajapinnat.

Tee public static Main() -metodi, joka hoitaa käyttöliittymää.
Sovelluksella hoidetaan tuotevarastoa, jossa voi olla kirjoja ja äänitteitä.
Tuotevarasto toteutetaan SekatavaraMarket luokan oliolla, joka on aluksi tyhjä.
Käyttäliittymässä on pääohjelmasilmukka, jossa kysytääm komentoja, joiden perusteella tehdään toimintoja tuotevarastoon.

Toteutettavat komennot ovat:

a (add) - lisätään kirja tai äänite tuotevarastoon
p (print) - tulostetaan koko tuotevaraston sisältö
d (delete) - poistetaan tuote tuotevarastosta koodin mukaan
g (get) - haetaan tuote tuotevarastosta koodin mukaan
q (quit) - poistutaan sovelluksesta
Sovellus sijoitetaan nimiavaruuteen SekatavaraKauppa.
Esimerkki käyttöliittymästä:

Anna komento: a
Lisäätkö kirjan (k) vai äänitteen (ä)? k
Anna kirjan tekijä: Aleksis Kivi
Anna kirjan nimi: Seitsemän veljestä
Anna kirjan koodi: 123
Anna kirjan hinta: 12,3
Anna komento: a
Lisäätkö kirjan (k) vai äänitteen (ä)? ä
Anna äänitteen esittäjä: Juice Leskinen
Anna äänitteen nimi: Hauho
Anna äänitteen sanoittaja: Juice Leskinen
Anna äänitteen säveltäjä: Juice Leskinen
Anna äänitteen koodi: 456
Anna äänitteen hinta: 4,56
Anna komento: p
Kirja - Aleksis Kivi: Seitsemän veljestä, 123, 12,3 euroa
Äänite - Juice Leskinen: Hauho, san Juice Leskinen, säv Juice Leskinen, 456, 4,56 euroa
Anna komento: g
Anna haettavan tuotteen koodi: 456
Äänite - Juice Leskinen: Hauho, san Juice Leskinen, säv Juice Leskinen, 456, 4,56 euroa
Anna komento: d
Anna poistettavan tuotteen koodi: 456
Anna komento: g
Anna haettavan tuotteen koodi: 456
Tuotetta ei löytynyt!
Anna komento: p
Kirja - Aleksis Kivi: Seitsemän veljestä, 123, 12,3 euroa
Anna komento: q
 */
namespace SekatavaraKauppa2
{
    class Program
    {
        static void Main(string[] args)
        {
            SekatavaraMarket marketti = new SekatavaraMarket();
            string valinta;
            do
            {
                Console.Write("Anna komento: ");
                valinta = Console.ReadLine();

                switch (valinta)
                {
                    case "a":
                        marketti.Kysy();
                        break;
                    case "p":
                        marketti.ToString();
                        break;
                    case "d":
                        marketti.Poista("");
                        break;
                    case "g":
                        marketti.Hae("");
                        
                        break;
                }
            } while (valinta != "q");
        }
    }
}
