using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO2_Teht3
{
    public partial class Henkilotiedot : Form
    {
        public Henkilotiedot()
        {
            InitializeComponent();

        }

        private void Txtb_postinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sallitaan vain numeroita ja backspace yms.
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
            
        }

        private void Dtp_syntpv_Leave(object sender, EventArgs e)
        {

            dtp_syntpv.MaxDate = DateTime.Today;
        }

        private void Btn_lisaa_Click(object sender, EventArgs e)
        {
            string tiedot;
            string syntpv;
            //virhettä...
            if (txtb_etunimi.Text.Length < 0 || txtb_sukunimi.Text.Length < 0 || txtb_puhelinnro.Text.Length < 0 || txtb_lahiosoite.Text.Length < 0 || txtb_postinro.Text.Length < 0 || txtb_postitmp.Text.Length < 0)
            {
                tyhjakentta tk = new tyhjakentta();
                tk.ShowDialog();
            }
            else
            {
                //Siirretään listboksiin
                syntpv = dtp_syntpv.Value.ToString("dd/MM/yyyy");
                tiedot = txtb_etunimi.Text + " " + txtb_sukunimi.Text + " " + txtb_puhelinnro.Text + " " + txtb_lahiosoite.Text + " " + txtb_postinro.Text + " " + txtb_postitmp.Text + " " + syntpv;
                lb_henkilot.Items.Add(tiedot);
            }
        }

        private void Lb_henkilot_Click(object sender, EventArgs e)
        {
            string tiedot = lb_henkilot.Items[lb_henkilot.SelectedIndex].ToString();

            string[] patkat = tiedot.Split(' ');
            txtb_etunimi.Text = patkat[0];
            txtb_sukunimi.Text = patkat[1];
            txtb_puhelinnro.Text = patkat[2];
            txtb_lahiosoite.Text = patkat[3] + " " + patkat[4]; //Talonnumero mukaan
            txtb_postinro.Text = patkat[5];
            txtb_postitmp.Text = patkat[6];
            dtp_syntpv.Value = Convert.ToDateTime(patkat[7]);

            
             lb_henkilot.Items.Remove(lb_henkilot.SelectedItem);
            
            


        }
    }
}
