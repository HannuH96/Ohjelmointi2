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

namespace Ohjelmointi2_Vko3_T2tai5
{
    public partial class Form1 : Form
    {
        bool muuttu;
        public Form1()
        {
            InitializeComponent();
            muuttu = false;
        }



        private void tsmi_tuo_click(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo("C:\\temp\\");
            if(dir.Exists == false)
            {
                rtb_tekstilaatikko.Text = "Kansiota c:\\ " +"temp ei ole olemassa";

            }
            if(File.Exists("C:\\temp\\teksti.txt") == false)
            {
                rtb_tekstilaatikko.Text = "Tiedostoa c:\\" + "temp\\" + "teksti.txt ei ole olemassa";
                
            }
            else
            {
                StreamReader sr = new StreamReader("C:\\temp\\teksti.txt");
                rtb_tekstilaatikko.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void Tsmi_vie_Click(object sender, EventArgs e)
        {
            string teksti;
            int i;
            DirectoryInfo dir = new DirectoryInfo("C:\\temp\\");

            //tarksitellaan kansioiden ja tiedostojen olemassaoloa...
            if(dir.Exists == false)
            {
                Directory.CreateDirectory("C:\\temp\\");
            }

            if(File.Exists("C:\\temp\\teksti.txt") == false)
            {
                File.Create("C:\\temp\\teksti.txt");
            }
            //Poistetaan vanhat tekstit
            StreamWriter tyhjennys = new StreamWriter("C:\\temp\\teksti.txt");
            tyhjennys.Write("");
            tyhjennys.Close();

            //Kirjoitetaan tiedostoon...
            for (i = 0; i < rtb_tekstilaatikko.Lines.Length; i++)
            {
                teksti = rtb_tekstilaatikko.Lines[i];


                StreamWriter sw = new StreamWriter("C:\\temp\\teksti.txt", true);
                sw.WriteLine(teksti);
                sw.Close();
            }

            
        }

        private void Rtb_tekstilaatikko_TextChanged(object sender, EventArgs e)
        {
            muuttu = true;
        }

        private void Tsmi_lopeta_Click(object sender, EventArgs e)
        {
            DialogResult rs = DialogResult.Yes;

            if (muuttu == true)
            {
                rs = MessageBox.Show("Lopetetaanko ? ", "Exit", MessageBoxButtons.YesNo);
            }
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tsb_poista_Click(object sender, EventArgs e)
        {
            string poista = tstxtb_poista.Text;
            rtb_tekstilaatikko.Text = rtb_tekstilaatikko.Text.Replace(poista, "");
        }
    }
}
