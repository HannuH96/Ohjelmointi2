using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO2_T2
{
    public partial class Paikanvaihto : Form
    {
        public Paikanvaihto()
        {
            InitializeComponent();
        }

        private void Btn_siirra_Click(object sender, EventArgs e)
        {
            bool testx, testy;
            int xkoord, ykoord; 

            testx =  int.TryParse(txtb_x.Text, out xkoord);
            testy = int.TryParse(txtb_y.Text, out ykoord);

            //Vaihetaan nollaksi jos on teksti tai negat.
            if(testx == false || xkoord < 0)
            {
                xkoord = 0;
                txtb_x.Text = "0";
            }

            if(testy == false || ykoord <0)
            {
                ykoord = 0;
                txtb_y.Text = "0";
            }
            

            //ekstrahommeli
            //Ei päästetä nappia ulos laatikosta. Nappi on kokonaan laatikon sisällä 0-210X ja 0-240 Y (Jos ei laiteta laatikkoa koko näytölle)
            /*
            if(xkoord > 210)
            {
                xkoord = 210;
                txtb_x.Text = "210";
            }

            if(ykoord > 240)
            {
                ykoord = 240;
                txtb_y.Text = "240";
            }
            */

            btn_siirra.Location = new Point(xkoord, ykoord);


        }
    }
}
