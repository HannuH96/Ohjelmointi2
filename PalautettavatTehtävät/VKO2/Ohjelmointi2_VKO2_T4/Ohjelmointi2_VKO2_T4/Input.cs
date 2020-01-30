using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO2_T4
{
    public partial class Input : Form
    {
        struct Mittaus
        {
            public string nimi;
            public string mitattavaarvo;
            public string toiminnassa;
            public string sijainti;
          

            public string Nimi
            {
                get { return nimi; }
            }

            public string Mitattava
            {
                get { return mitattavaarvo; }
            }

            public string Toiminnassa
            {
                get { return toiminnassa; }
            }

            public string Sijainti
            {
                get { return sijainti; }
            }
            
            
        }

        List<Mittaus> mittaukset;

        public Input()
        {
            InitializeComponent();
            mittaukset = new List<Mittaus>();
            
        }


        private void Btn_vie_Click(object sender, EventArgs e)
        {
 
            //Valitsemattomilla ja tyhjällä nimellä heitetään virheilmo...

            if (cbb_sijainti.Text == "Valitse" || cbb_mitattava.Text == "Valitse" || txtb_nimi.Text == "")
            {
                Virhe virhe = new Virhe();

                virhe.ShowDialog();
            }
            else
            {


                Mittaus x;
                x.nimi = txtb_nimi.Text;

                x.mitattavaarvo = cbb_mitattava.Text;

                //Tehdään nyt vähän nätimmäksi, ei tarvi olla niin pitkä teksti siinä ruudussa.
                if (chb_toiminnassa.Checked == false)
                {
                    x.toiminnassa = "Ei";
                }
                else
                {
                    x.toiminnassa = "Kyllä";
                }

                x.sijainti = cbb_sijainti.Text;

                mittaukset.Add(x);
                
                dgv_tiedot.DataSource = null;
                dgv_tiedot.DataSource = mittaukset;
                

            }
           


        }


    }
}
