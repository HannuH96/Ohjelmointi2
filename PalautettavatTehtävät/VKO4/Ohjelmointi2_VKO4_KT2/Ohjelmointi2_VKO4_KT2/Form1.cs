using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO4_KT2
{
    public partial class Form1 : Form
    {
        Random rng;
        int arvattava;
        int yritykset = 0;
        public Form1()
        {
            InitializeComponent();
            rng = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arvattava = rng.Next(1, 101);
        }

        private void Btn_arvaa_Click(object sender, EventArgs e)
        {
            int arvattu;
            

            try
            {
                arvattu = int.Parse(txtb_arvattu.Text);
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                
                //Vertaillaan arvottuun lukuun.
                if(arvattu > arvattava)
                {
                    tssl_tulos.Text = "Liian suuri";
                    yritykset++;
                }
                else if(arvattu < arvattava)
                {
                    tssl_tulos.Text = "Liian pieni";
                    yritykset++;
                }
                else
                {
                    tssl_tulos.Text = "Oikein arvattu!";
                    yritykset++;

                    
                    result = MessageBox.Show("Arvasit oikein yrityskerralla " + yritykset.ToString() + ".\rPelataataanko uudestaan?", "Oikein arvattu!", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        arvattava = rng.Next(1, 101);
                        yritykset = 0;
                        tssl_tulos.Text = "Uusi kierros";
                    }
                    else
                    {
                        //Koska ei haluta arvata uudestaaan, sammutetaan ohjelma.
                        this.Close();
                    }
                    
                }

                tssl_arvatutnumero.Text = yritykset.ToString();
            }
            catch
            {
                tssl_tulos.Text = "Anna kokonaisluku!";
                txtb_arvattu.Focus();
                
            }
        }


    }
}
