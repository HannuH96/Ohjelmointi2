using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Ohjelmointi2_Harjoitustyö
{
    public partial class form_tulostaulukko : Form
    {
        List<Pelaaja> pelaajalista;
        
        public form_tulostaulukko()
        {
            InitializeComponent();
        }
        public form_tulostaulukko(List<Pelaaja> f)
        {
            InitializeComponent();
            pelaajalista = f;
            dgv_tulostaulukko.DataSource = pelaajalista;
        }

        //Varmistetaan halutaanko poistaa rivi, jos halutaan, rivi poistetaan.
        private void Dgv_tulostaulukko_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rivi;
            DialogResult dr = DialogResult.None;
            MessageBoxButtons napit = MessageBoxButtons.YesNo;

            rivi = dgv_tulostaulukko.CurrentRow.Index;

            if(rivi >= 0)
            {
                dr = MessageBox.Show("Haluatko poistaa pelaajan tiedot?", "Varmistusboksi", napit);
                if(dr == DialogResult.Yes)
                {
                    pelaajalista.RemoveAt(rivi);
                    SerializeXML(pelaajalista);
                    dgv_tulostaulukko.DataSource = null;
                    dgv_tulostaulukko.DataSource = pelaajalista;

                }
            }
        }
        //Tallennetaan tiedostoon...
        public void SerializeXML(List<Pelaaja> input)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\rnpelaajat.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }
    }
}
