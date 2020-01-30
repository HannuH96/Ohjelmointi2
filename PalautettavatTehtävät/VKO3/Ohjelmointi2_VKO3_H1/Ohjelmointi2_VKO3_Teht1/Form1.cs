using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO3_Teht1
{
    public partial class Form1 : Form
    {
        // Käytän tarkistamaan kumpi nappi painettu,
        //jotta voidaan käyttää samaa funktiota molemmille napeille.
        Painettu x = new Painettu();

        public Form1()
        {
            InitializeComponent();
            btn_nappi1.Click += new EventHandler(Nappipainettu);
            btn_nappi2.Click += new EventHandler(Nappipainettu);
            
            x.painettu1 = false;
            x.painettu2 = false;
        }

        private void Btn_nappi1_Click(object sender, EventArgs e)
        {
            x.painettu1 = true;
        }

        private void Btn_nappi2_Click(object sender, EventArgs e)
        {
            x.painettu2 = true;
        }

        private void Nappipainettu(object sender, EventArgs e)
        {
            string painettu = "0";
            int xkoord = 0;
            int ykoord = 0;
            if(x.painettu1 == true)
            {
               //Otetaan napin koordinaatit ja laitetaan sopivaan paikkaan tekstiboksin tarvitsema ero
               xkoord = btn_nappi1.Location.X + 100;
               ykoord = btn_nappi1.Location.Y ;
               painettu = "1";
                //poistetaan painettu-tila jotta saadaan tuo toinenkin toimimaan
               x.painettu1 = false;

            }
            else if (x.painettu2 == true)
            {
                xkoord = btn_nappi2.Location.X + 100;
                ykoord = btn_nappi2.Location.Y ;
                painettu = "2";
                x.painettu2 = false;
            }

            
            TextBox txtb_uusi = new TextBox();
            txtb_uusi.Name = "txtb_uusi"+painettu;
            txtb_uusi.Location = new System.Drawing.Point(xkoord, ykoord);
            txtb_uusi.Size = new System.Drawing.Size(50, 25);
            //Pittää määrätä eventtikin vielä... 
            txtb_uusi.Leave += new System.EventHandler(txtb_uusi_Leave);

            
            this.Controls.Add(txtb_uusi);
            

            

        }


        private void txtb_uusi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
          

            if (tb.Location.Y == btn_nappi1.Location.Y)
            {
                btn_nappi1.Text = tb.Text;

            }
            else if(tb.Location.Y == btn_nappi2.Location.Y)
            {
                btn_nappi2.Text = tb.Text;
            }

        }

    }
}
