using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjel2_VKO_Harjoitukset
{
    class Program
    {
        public class Auto
        {
            public string merkki;
            public string malli;
            public string tyyppi;
            public int vuosimalli;
            public string rekisterinro;
            public Omistaja omistaja = new Omistaja();

            public void Kysytiedot()
            {
                bool test;
                Console.WriteLine("Anna auton merkki: ");
                merkki = Console.ReadLine();

                Console.WriteLine("Anna auton malli: ");
                malli = Console.ReadLine();

                Console.WriteLine("Anna auton tyyppi: ");
                tyyppi = Console.ReadLine();

                Console.WriteLine("Anna auton vuosimalli: ");
                test = int.TryParse(Console.ReadLine(), out vuosimalli);
                while(test == false)
                {
                    Console.WriteLine("Vuosimallin oltava kokonaislukumuodossa, ei tekstinä.\nAnna auton vuosimalli: ");
                    test = int.TryParse(Console.ReadLine(), out vuosimalli);
                }

                Console.WriteLine("Anna auton rekisterinumero: ");
                rekisterinro = Console.ReadLine();

                omistaja.Tiedot();
            }
        }
        public class Omistaja
        {
            public string etun;
            public string sukun;
            public string hetu;

            public void Tiedot()
            {
                Console.WriteLine("Anna auton omistajan etunimi: ");
                etun = Console.ReadLine();

                Console.WriteLine("Anna auton omistajan sukunimi: ");
                sukun = Console.ReadLine();

                Console.WriteLine("Anna auton omistajan henkilötunnus: ");
                hetu = Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
            Auto kaara = new Auto();
            kaara.Kysytiedot();

        }
    }
}
/*
 * Esittele seuraavat luokat



Yksittäisestä autosta on tietoina

- merkki

- malli

- tyyppi

- vuosimalli

- rekisterinro

- omistaja

Yksittäisestä omistajasta on tietoina

- etunimi

- sukunimi

- hetu

Käytä siis luokkia sekä autolle että omistajalle! Tee funktiot kysytiedot() molemmille luokille. 
Ko funktio siis kysyy luokan jäsenmuuttujiin arvot.
Huomaa, että auton omistajatietojen kohdalla pitää kutsua omistaja-luokan kysytiedot() -funktioita.
 */
