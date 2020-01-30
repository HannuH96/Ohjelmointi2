using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmointi2_Harjoitustyö
{
    public class Pelaaja
    {
        public string etunimi;
        public string sukunimi;
        public int syntymavuosi;
        public int voitot = 0;
        public int tappiot = 0;
        public int tasapelit = 0;
        public double peliaika = 0;
        public string Kokonimi
        {
            get { return etunimi + " " + sukunimi; }
        }
        public int Syntymavuosi
        {
            get { return syntymavuosi; }
        }
        public int Voitot
        {
            get { return voitot; }
        }
        public int Tappiot
        {
            get { return tappiot; }
        }
        public int Tasapelit
        {
            get { return tasapelit; }
        }
        public string Peliaika
        {
            get { return Math.Truncate(peliaika * 100) / 100 + "s"; }
            
        }


    }

    
}
