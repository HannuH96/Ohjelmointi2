using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO4_VT1TT2
{
    public partial class Form1 : Form
    {
        List<int> tuodut;
        int listaindex;

        public Form1()
        {
            InitializeComponent();

            tuodut = new List<int>();
            listaindex = 0;
        }

        private void Tsmi_vie_Click(object sender, EventArgs e)
        {
            int i;
            int arvottu;
            string arvottustring;
            Random rng = new Random();

            XmlWriter kokeilu = XmlWriter.Create("viety.xml");
            kokeilu.WriteStartDocument();
            kokeilu.WriteStartElement("arvotut");

            for (i = 0; i < 100; i++)
            {
                kokeilu.WriteStartElement("numero");
                arvottu = rng.Next(1, 21);
                arvottustring = arvottu.ToString(); 
                kokeilu.WriteString(arvottustring);
                kokeilu.WriteEndElement();
            }
            kokeilu.WriteEndDocument();
            kokeilu.Close();

            tsmi_tuo.Enabled = true;

        }

        private void Tsmi_tuo_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            int i,luku;
            //Tyhjätään lista, jotta voi laittaa uudet luvut sisään tuodessa uutta listaa.
            tuodut.Clear();
            listaindex = 0;


            xml.Load("viety.xml");
            XmlNodeList testi = xml.GetElementsByTagName("numero");


            for (i = 0; i < testi.Count; i++)
            {
                
               luku = int.Parse(testi.Item(i).InnerText);
               tuodut.Add(luku);
            }
            txtb_naytto.Text = tuodut.First().ToString();

            //Ei anneta painaa nappeja/kirjoittaa tekstiä ennen ensimmäistä tuontia.
            btn_edellinen.Enabled = true;
            btn_seuraava.Enabled = true;
            txtb_naytto.Enabled = true;
            prb_sijainti.Value = listaindex;
        }

        private void Btn_seuraava_Click(object sender, EventArgs e)
        {
            listaindex++;
 
            if(listaindex > 99)
            {
                listaindex = 0;
            }
            txtb_naytto.Text = tuodut.ElementAt<int>(listaindex).ToString();
            prb_sijainti.Value = listaindex;
        }

        private void Btn_edellinen_Click(object sender, EventArgs e)
        {
            listaindex--;
            
            if(listaindex < 0)
            {
                listaindex = 99;
            }
            txtb_naytto.Text = tuodut.ElementAt<int>(listaindex).ToString();
            prb_sijainti.Value = listaindex;
        }

        

        private void Txtb_naytto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int uusiarvo;

            //Ei sallita kirjaimia tms.
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void Txtb_naytto_KeyUp(object sender, KeyEventArgs e)
        {
            //Ei toimi keypressissä, toimii keyupissa... Muista ettii syy
            int uusiarvo;

            uusiarvo = int.Parse(txtb_naytto.Text);
            tuodut.RemoveAt(listaindex);
            tuodut.Insert(listaindex, uusiarvo); 
        }


    }
}
