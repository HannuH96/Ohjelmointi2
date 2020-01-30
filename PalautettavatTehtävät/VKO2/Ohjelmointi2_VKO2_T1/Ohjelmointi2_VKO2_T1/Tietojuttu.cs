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

namespace Ohjelmointi2_VKO2_T1
{
    public struct Person
    {
        public string etun, sukun, jobtitle, syntpv, jobstart, jobend;
        

    }


    public partial class Tietojuttu : Form
    {
        public Tietojuttu()
        {
            InitializeComponent();
        }
        private void Btn_tallenna_Click(object sender, EventArgs e)
        {
            Person x = new Person();


            //testataan virheitä annetuissa tiedoissa.
            if (String.IsNullOrWhiteSpace(txtb_etunimi.Text) == false && String.IsNullOrWhiteSpace(txtb_sukunimi.Text) == false && cmbb_jobtitle.Text != "Valitse") 
            {

                //Nää ois varmaan tarkotus olla tuolla structin puolella. Toimii kyllä tästäkin ainakin tässä yhteydessä.
                x.etun = txtb_etunimi.Text;
                x.sukun = txtb_sukunimi.Text;
                x.jobtitle = cmbb_jobtitle.Text;

                x.syntpv = dtp_syntpv.Value.ToString("dd/MM/yyyy");
                x.jobstart = dtp_jobstart.Value.ToString("dd/MM/yyyy");
                x.jobend = dtp_jobend.Value.ToString("dd/MM/yyyy");



                //Tehdään nyt jotakin järkevää tiedoilla...
                //Luodaan kansio(t) jos niitä ei ole.
                if (Directory.Exists("c:\\temp\\") == false)
                {
                    Directory.CreateDirectory("c:\\temp\\");
                }

                if (Directory.Exists("c:\\temp\\tyontekijat\\") == false)
                {
                    Directory.CreateDirectory("c:\\temp\\tyontekijat\\");
                }

                StreamWriter sw = new StreamWriter("c:\\temp\\tyontekijat\\" + x.sukun + "_" + x.etun + ".txt");

                sw.WriteLine("etunimi: " + x.etun);
                sw.WriteLine("sukunimi: " + x.sukun);
                sw.WriteLine("syntymäpäivä: " + x.syntpv);
                sw.WriteLine("työnimike: " + x.jobtitle);
                sw.WriteLine("työsuhteen aloitusajankohta: " + x.jobstart);
                sw.WriteLine("työsuhteen päättymisajankohta: " + x.jobend);

                sw.Close();

            }
            else // Jos joku nimikenttä on tyhjä tai työnimikettä ei valittu laitetaan tämä
            {
                NimiTyöVirhe ntv = new NimiTyöVirhe();
                ntv.ShowDialog();
            }

        }
    }
}
