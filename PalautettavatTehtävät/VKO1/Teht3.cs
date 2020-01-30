using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjel2_VKO_Harjoitukset
{
    class Program
    {
        public struct Pythagora
        {
            public double a;
            public double b;
            public double c;
            public bool test;
            

            public void RatkaisePuuttuva()
            {
               

               if(a == 0 && b == 0) //Nyt on kyllä ruma... Pitäs löytää nätimpi keino tähän.
               {
                    test = false;
               }
               else if (a == 0 && c == 0)
               {
                    test = false;
               }
               else if (b == 0 && c == 0)
               {
                    test = false;
               }
               else if (a==0)
               {
                    a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                    test = true;
               }
               else if (b==0)
               {
                    b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                    test = true;
               }
               else if (c==0)
               {
                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    test = true;
               }


            }

        }
        static void Main(string[] args)
        {
            Pythagora kolmio = default(Pythagora);
            bool test;

            Console.WriteLine("Anna kolmiolle kateetti a, jos se on tuntematon, anna 0: ");
            test = double.TryParse(Console.ReadLine(), out kolmio.a);
            while(test == false) //Ei päästetä läpi ilman lukuarvoa...
            {
                Console.WriteLine("Jokin meni pieleen, kokeile uudestaan.");
                Console.WriteLine("Anna kolmiolle kateetti a, jos se on tuntematon, anna 0: ");
                test = double.TryParse(Console.ReadLine(), out kolmio.a);
            }

            Console.WriteLine("Anna kolmiolle kateetti b, jos se on tuntematon, anna 0: ");
            test = double.TryParse(Console.ReadLine(), out kolmio.b);
            while (test == false)//Ei päästetä läpi ilman lukuarvoa...
            {
                Console.WriteLine("Jokin meni pieleen, kokeile uudestaan.");
                Console.WriteLine("Anna kolmiolle kateetti b, jos se on tuntematon, anna 0: ");
                test = double.TryParse(Console.ReadLine(), out kolmio.b);
            }

            Console.WriteLine("Anna kolmiolle hypotenuusa c, jos se on tuntematon, anna 0: ");
            test = double.TryParse(Console.ReadLine(), out kolmio.c);
            while (test == false)//Ei päästetä läpi ilman lukuarvoa...
            {
                Console.WriteLine("Jokin meni pieleen, kokeile uudestaan.");
                Console.WriteLine("Anna kolmiolle hypotenuusa c, jos se on tuntematon, anna 0: ");
                test = double.TryParse(Console.ReadLine(), out kolmio.c);
            }

            kolmio.RatkaisePuuttuva();

            if(kolmio.test == false)
            {
                Console.WriteLine("Useampi kuin yksi tuntematon, ei voi ratkaista.");
            }
            else
            {
                Console.WriteLine("Kolmion kateetit ovat {0} ja {1}, sekä hypotenuusa {2}", kolmio.a, kolmio.b, kolmio.c);
            }

        }
    }
}

/*
 Tee tietue Pythagora, jolla on tietoinaan ko lausekkeen kertoimet a, b ja c. - juu
 Tee tietueelle funktio RatkaisePuuttuva, joka laskee puuttuvan arvon (jos puuttuu eli arvo on 0). 
 Jos kaksi arvoa puuttuu, niin haluttua arvoa ei tietenkään voida ratkaista. 
 Tällöin funktio palauttaa arvon false, muutoin arvon true.

a2 = c2 - b2

b2 = c2 - a2

c2 = a2+ b2
 */
