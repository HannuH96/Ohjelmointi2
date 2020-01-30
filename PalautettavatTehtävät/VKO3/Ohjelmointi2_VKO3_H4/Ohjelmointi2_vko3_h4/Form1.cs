using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_vko3_h4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtb_luku1_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtb_luku1.Text);

                sslbl_status.Text = "OK";
            }
            catch (FormatException)
            {
                sslbl_status.Text = "Virheellinen syöte";
                txtb_luku1.Focus();
            }
            catch (OverflowException)
            {
                sslbl_status.Text = "Virheellinen syöte";
                txtb_luku1.Focus();
            }

        }

        private void Txtb_luku2_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtb_luku2.Text);

                sslbl_status.Text = "OK";
            }
            catch (FormatException)
            {
                sslbl_status.Text = "Virheellinen syöte";
                txtb_luku2.Focus();
            }
            catch (OverflowException)
            {
                sslbl_status.Text = "Virheellinen syöte";
                txtb_luku2.Focus();
            }
        }
    }
}
