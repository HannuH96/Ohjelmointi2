using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO3_H3
{
    public partial class Form1 : Form
    {
        pisteet piste;
        Timer aika, reset, pelinkesto;
        
        Button btn;
        public Form1()
        {
            InitializeComponent();
            piste = new pisteet();
            aika = new Timer();
            btn = new Button();
            reset = new Timer();
            pelinkesto = new Timer();
        }

        private void Tsb_startgame_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            int x, y;

            //x minimi ja maksimi 0-299
            x = rng.Next(0,300);

            //y minimi ja maksimi 25-306
            y = rng.Next(25, 307);
 
            btn.Name = "btn_pelinappi";
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(50, 25);
            btn.Text = "CLICK";
            btn.Click += new System.EventHandler(btn_pelinappi_click);
            this.Controls.Add(btn);

            aika.Enabled = true;
            aika.Interval = 10000;
            aika.Tick += new System.EventHandler(ohimeni);

            pelinkesto.Enabled = true;
            pelinkesto.Interval = 1000;
            pelinkesto.Tick += new System.EventHandler(ajastin);
            
        }

        private void btn_pelinappi_click(object sender, EventArgs e)
        {
            Random rng = new Random();

            int x, y;

            //x minimi ja maksimi 0-299
            x = rng.Next(0, 300);

            //y minimi ja maksimi 25-306
            y = rng.Next(25, 307);

            piste.osuma++;
            piste.kok++;
            sslbl_tulos.Text = "Osumat: " + piste.osuma.ToString();

            //alotetaan ajastin uusiks uudella ajalla
            aika.Enabled = false;
            aika.Interval = 10000 / piste.osuma;
            aika.Enabled = true;

            btn.Location = new System.Drawing.Point(x, y);
        }

        private void ohimeni(object sender, EventArgs e)
        {
            Random rng = new Random();
            

            int x, y;

            //x minimi ja maksimi 0-299
            x = rng.Next(0, 300);

            //y minimi ja maksimi 25-306
            y = rng.Next(25, 307);

            piste.ohi++;
            piste.kok++;
            sslbl_huti.Text = "Ohi: " + piste.ohi.ToString() + " / 3";

            btn.Location = new System.Drawing.Point(x, y);

            if(piste.ohi >= 3)
            {


                this.Controls.Remove(btn);
                aika.Enabled = false;
                pelinkesto.Enabled = false;
                reset.Interval = 3000;
                reset.Enabled = true;
                reset.Tick += new System.EventHandler(Resetpeli);

                //Annetaan tulokset
                string tulokset = "Peli kesti " + piste.peliaika + " sekuntia, sait " + piste.osuma + " pistettä.";


                MessageBox.Show(tulokset, "Peli ohi!", MessageBoxButtons.OK);

            }
        }
        private void Resetpeli(object sender, EventArgs e)
        {

            //Palautetaan alkutilaan, voi pelata vaikka uudestaan.
            reset.Enabled = false;
            piste.ohi = 0;
            piste.kok = 0;
            piste.osuma = 0;
            sslbl_huti.Text = "Ohi: " + piste.ohi.ToString() + " / 3";
            sslbl_tulos.Text = "Osumat: " + piste.osuma.ToString();
            sslbl_aika.Text = "Aika: 0 s";

        }

        private void ajastin(object sender, EventArgs e)
        {
            piste.peliaika++;

            sslbl_aika.Text = "Aika: " + piste.peliaika + " s";
        }


    }
}
