using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjel2_vko1_kotiteht
{
    class Teht1
    {
        public struct Kulutus
        {
            public int km; 
            public int l;
        }
        static void Main(string[] args)
        {
            Kulutus k = default(Kulutus);
            KysyKulutus(out k);

            LaskeTulosta(k);

        }

        static void KysyKulutus(out Kulutus k)
        {
            bool test;
            Console.Write("Anna kuljettu matka kokonaislukuna (kilometejä): ");
            test = int.TryParse(Console.ReadLine(), out k.km);

            //Ei päästetä läpi nollalla tai tekstillä yms.

            while (test == false || k.km == 0)
            {
                Console.Write("Et antanut kokonaislukua, tai annoit nollan.\n");
                Console.Write("Anna kuljettu matka kokonaislukuna (kilometejä): ");
                test = int.TryParse(Console.ReadLine(), out k.km);
            }

            Console.Write("Anna kulutettu polttoainemäärä kokonaislukuna (litroja): ");
            test = int.TryParse(Console.ReadLine(), out k.l);

            while (test == false)
            {
                Console.Write("Et antanut kokonaislukua.\n");
                Console.Write("Anna kulutettu polttoainemäärä kokonaislukuna (litroja): ");
                test = int.TryParse(Console.ReadLine(), out k.l);
            }
     

        }
        
        static void LaskeTulosta(Kulutus k)
        {
            double kulu;
            //Pakko muuttaa arvot doubleksi, kun ei toimi tehtävänannon mukaisena integerinä/kokonaislukuna. 
            //Oletan, että tässä on jokin toinenkin ratkaisu jota en nyt mieleen saa.
            double l1 = k.l; 
            double l2 = k.km;


            kulu = l1 / l2 * 100; 

            Console.WriteLine("Kulutus on {0:f2} l/100km", kulu); 
        }
    }
}
/*
 * Esittele tietue (struct), jolla on kaksi kokonaislukuarvoa. 
 * Toinen niistä on kuljettu matka (km) ja toinen on kulutettu polttoainemäärä (l).
 * Esittele tietueesta muuttuja ja kysy käyttäjältä arvot tietueen muuttujiin. 
 * Tulosta polttoaineen kulutus (litraa/100km) siten, että käytät tietueeseen tallennettuja arvoja
 */
