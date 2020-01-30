using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjel2_VKO_Harjoitukset
{
    class Program
    {
        public struct Henkilo
        {
            public string etun;
            public string sukun;
            public double pituus;
            public double paino;
        }
        static void Main(string[] args)
        {
            Henkilo[] taulu = new Henkilo[10]; 
            KysyTiedot(taulu);
            LaskePainoIndeksi(taulu);

        }
        static void KysyTiedot(Henkilo[] taulu)
        {
            int i;
            bool test;
            for (i = 0; i < taulu.Length; i++)
            {
                Console.WriteLine("Anna henkilön #{0} etunimi: ", i+1);
                taulu[i].etun = Console.ReadLine();

                Console.WriteLine("Anna henkilön #{0} sukunimi: ", i + 1);
                taulu[i].sukun = Console.ReadLine();

                Console.WriteLine("Anna henkilön #{0} pituus metreinä: ", i + 1);
                test = double.TryParse(Console.ReadLine(), out taulu[i].pituus);

                while(test==false || taulu[i].pituus == 0) //ei kenenkään pituus voi olla 0,00 metriä, tai teksti...
                {
                    Console.Write("Annoit nollan tai jotain muuta kuin pituuden\n.");
                    Console.WriteLine("Anna henkilön #{0} pituus: ", i + 1);
                    test = double.TryParse(Console.ReadLine(), out taulu[i].pituus);
                }

                Console.WriteLine("Anna henkilön #{0} paino kilogrammoina: ", i + 1); //ei kenenkään paino voi olla 0,00 kiloa, tai teksti...
                test = double.TryParse(Console.ReadLine(), out taulu[i].paino);
                while(test==false || taulu[i].paino == 0)
                {
                    Console.Write("Annoit nollan tai jotain muuta kuin painon.\n");
                    Console.WriteLine("Anna henkilön #{0} paino kilogrammoina: ", i + 1);
                    test = double.TryParse(Console.ReadLine(), out taulu[i].paino);
                }
            }

        }
        static void LaskePainoIndeksi(Henkilo[] taulu)
        {
            double kokbmi = 0;
            double keskbmi;
            int i;

            for (i = 0; i < taulu.Length; i++) 
            {
                kokbmi = kokbmi + (taulu[i].paino / Math.Pow(taulu[i].pituus, 2));
            }

            keskbmi = kokbmi / taulu.Length;

            Console.WriteLine("Annettujen henkilöiden keskimääräinen painoindeksi on {0:f2}", keskbmi);

        }
    }
}
/*
 * Esittele 10 alkioinen taulukko, jossa henkilötietoja. Yksittäisestä henkilöstä on tietoina

- etunimi

- sukunimi

- pituus 

- paino

    Käytä tietuetyyppiä! Tee funktio LaskePainoindeksi, joka saa parametrinaan ko. taulukon ja tulostaa henkilöiden keskimääräisen painoindeksin. 
    Joudut luonnollisesti tekemään pääohjelman, jossa joko kysyt 10 henkilön tiedot tai alustat arvot ohjelman sisällä.
    Ja painoideksihän lasketaa kaavalla 
    bmi = paino (kg) / pituus (m) ^2
*/
