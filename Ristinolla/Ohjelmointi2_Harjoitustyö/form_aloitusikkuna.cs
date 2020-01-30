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
    public partial class form_aloitusikkuna : Form
    {
        public List<Pelaaja> pelaajalista;
        public Pelaaja pelaaja0 = new Pelaaja();
        public Pelaaja pelaaja1 = new Pelaaja();
        form_ristinolla f;
        public int check;


        public form_aloitusikkuna()
        {
            InitializeComponent();
            f = new form_ristinolla(this);


            if(Directory.Exists("c:\\temp\\") == false)
            {
                Directory.CreateDirectory("c:\\temp\\");
            }


            if (File.Exists("c:\\temp\\rnpelaajat.xml"))
            {
                pelaajalista = DeserializeXML();
                        
            }
            else
            {
                pelaajalista = new List<Pelaaja>();
                
            }
            cbb_pelaajalista0.DisplayMember = "Kokonimi";
            cbb_pelaajalista1.DisplayMember = "Kokonimi";
            cbb_pelaajalista0.DataSource = pelaajalista;
            cbb_pelaajalista1.DataSource = pelaajalista;
            txtb_etun0.Text = "";
            txtb_sukun0.Text = "";
            txtb_syntpv0.Text = "";
            txtb_etun1.Text = "";
            txtb_sukun1.Text = "";
            txtb_syntpv1.Text = "";
            btn_start.Enabled = false;



        }
        //Luetaan listaan tiedostosta
        public List<Pelaaja> DeserializeXML()
        {
            if (File.Exists("c:\\temp\\rnpelaajat.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\rnpelaajat.xml");
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Pelaaja>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<Pelaaja>)obj;
            }
            else
            {
                return null;
            }
        }
        public void SerializeXML(List<Pelaaja> input)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\rnpelaajat.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }

        //AI-vastustajan valintaa, kirjoitetaan muodon vuoksi tekstikenttiin sen nimi, ja lukitaan tekstikentät.
        //Ja lisäksi starttinapin tilanmuutosta varten tarkistetaan onko kaikissa kentissä teksti.
        private void Chb_tietokone_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_tietokone.Checked == true)
            {
                txtb_etun1.Text = "Tieto";
                txtb_sukun1.Text = "Kone";
                txtb_sukun1.Enabled = false;
                txtb_etun1.Enabled = false;
                txtb_syntpv1.Text = "2019";
                txtb_syntpv1.Enabled = false;
                cbb_pelaajalista1.Enabled = false;
                cbb_pelaajalista1.Text = "Tieto Kone";
                check = 1;

                if (string.IsNullOrWhiteSpace(txtb_etun0.Text) == true || string.IsNullOrWhiteSpace(txtb_etun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun0.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv1.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv0.Text) == true)
                {
                    btn_start.Enabled = false;
                }
                else
                {
                    btn_start.Enabled = true;
                }

            }
            else if(chb_tietokone.Checked == false )
            {
                txtb_etun1.Text = "";
                txtb_sukun1.Text = "";
                txtb_syntpv1.Text = "";
                cbb_pelaajalista1.Text = "Valitse olemassaoleva pelaaja";
                txtb_syntpv1.Enabled = true;
                txtb_etun1.Enabled = true;
                txtb_sukun1.Enabled = true;
                cbb_pelaajalista1.Enabled = true;
                check = 0;
            }
        }

        //Aloittaa ristinollapelin, pelaajien lopetettua tallentaa/päivittää pelaajien tiedot, sekä sammuttaa ohjelman.
        private void Btn_start_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            int i = 0, j = 0;



            pelaaja0.etunimi = txtb_etun0.Text;
            pelaaja0.sukunimi = txtb_sukun0.Text;
            pelaaja0.syntymavuosi = int.Parse(txtb_syntpv0.Text);

            pelaaja1.etunimi = txtb_etun1.Text;
            pelaaja1.sukunimi = txtb_sukun1.Text;
            pelaaja1.syntymavuosi = int.Parse(txtb_syntpv1.Text);
            dr = f.ShowDialog();

           
            if (dr == DialogResult.OK)
            {
                
                foreach (Pelaaja x in pelaajalista)
                {
                   if(x.etunimi == pelaaja0.etunimi && x.sukunimi == pelaaja0.sukunimi && x.etunimi == pelaaja1.etunimi && x.sukunimi == pelaaja1.sukunimi)
                   {
                        x.voitot = pelaaja0.voitot;
                        x.tappiot = pelaaja0.tappiot;
                        x.tasapelit = pelaaja0.tasapelit;
                        x.peliaika = pelaaja0.peliaika;
                        i++;
                        j++;
                   }
                    else if (x.etunimi == pelaaja0.etunimi && x.sukunimi == pelaaja0.sukunimi )
                    {
                        x.voitot = pelaaja0.voitot;
                        x.tappiot = pelaaja0.tappiot;
                        x.tasapelit = pelaaja0.tasapelit;
                        x.peliaika = pelaaja0.peliaika;
                        i++;
                        
                    }
                    else if (x.etunimi == pelaaja1.etunimi && x.sukunimi == pelaaja1.sukunimi)
                    {
                        x.voitot = pelaaja1.voitot;
                        x.tappiot = pelaaja1.tappiot;
                        x.tasapelit = pelaaja1.tasapelit;
                        x.peliaika = pelaaja1.peliaika;
                        j++;
                        
                    }
                    
                }
                if (i != 0 && j != 0 )
                {
                    SerializeXML(pelaajalista);

                }
                else if(i!=0)
                {
                    if (chb_tietokone.Checked == false)
                    {
                        pelaajalista.Add(pelaaja1);
                    }
                    SerializeXML(pelaajalista);

                }
                else if(j!=0)
                {
                    pelaajalista.Add(pelaaja0);
                    SerializeXML(pelaajalista);


                }
                else
                {
                    pelaajalista.Add(pelaaja0);
                    if (chb_tietokone.Checked == false)
                    {
                        pelaajalista.Add(pelaaja1);
                    }
                    SerializeXML(pelaajalista);

                }
                
            }
            
            this.Close();

        }

        //Avataan tilastotaulukko, päivitetään pelaajalistat jos pelaajia poistettu.
        private void TilastotaulukkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form tulostaulukko = new form_tulostaulukko(pelaajalista);
            DialogResult dr = tulostaulukko.ShowDialog();

            if(dr == DialogResult.Cancel)
            {
                cbb_pelaajalista0.DataSource = null;
                cbb_pelaajalista1.DataSource = null;
                cbb_pelaajalista0.DisplayMember = "Kokonimi";
                cbb_pelaajalista1.DisplayMember = "Kokonimi";
                cbb_pelaajalista0.DataSource = pelaajalista;
                cbb_pelaajalista1.DataSource = pelaajalista;
                
            }
        }


        //Haetaan oikea tieto listalta ja täytetään kentät, tarkistetaan onko vielä tyhjiä kenttiä...
        private void Cbb_pelaajalista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_pelaajalista1.BindingContext = new BindingContext();
            int j = cbb_pelaajalista1.SelectedIndex;


                txtb_etun1.Text = pelaajalista[j].etunimi;
                txtb_sukun1.Text = pelaajalista[j].sukunimi;
                txtb_syntpv1.Text = pelaajalista[j].syntymavuosi.ToString();
                pelaaja1.voitot = pelaajalista[j].voitot;
                pelaaja1.tappiot = pelaajalista[j].tappiot;
                pelaaja1.tasapelit = pelaajalista[j].tasapelit;
                pelaaja1.peliaika = pelaajalista[j].peliaika;

            if (string.IsNullOrWhiteSpace(txtb_etun0.Text) == true || string.IsNullOrWhiteSpace(txtb_etun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun0.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv1.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv0.Text) == true)
            {
                btn_start.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
            }
        }
        //Haetaan oikea tieto listalta ja täytetään kentät, tarkistetaan onko vielä tyhjiä kenttiä...
        private void Cbb_pelaajalista0_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_pelaajalista0.BindingContext = new BindingContext();
            int i = cbb_pelaajalista0.SelectedIndex;

                txtb_etun0.Text = pelaajalista[i].etunimi;
                txtb_sukun0.Text = pelaajalista[i].sukunimi;
                txtb_syntpv0.Text = pelaajalista[i].syntymavuosi.ToString();
                pelaaja0.voitot = pelaajalista[i].voitot;
                pelaaja0.tappiot = pelaajalista[i].tappiot;
                pelaaja0.tasapelit = pelaajalista[i].tasapelit;
                pelaaja0.peliaika = pelaajalista[i].peliaika;

            if (string.IsNullOrWhiteSpace(txtb_etun0.Text) == true || string.IsNullOrWhiteSpace(txtb_etun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun0.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv1.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv0.Text) == true)
            {
                btn_start.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
            }

        }
        //Estetään molemmista syntymävuosibokseista kirjaimet ja muut ei-numerot.
        private void Txtb_syntpv1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) == true || Char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form_aloitusikkuna_Load(object sender, EventArgs e)
        {

        }
        //Tarkistetaan onko kaikissa kentissä tietoa viimeisen muutoksen jälkeen
        private void Txtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_etun0.Text) == true || string.IsNullOrWhiteSpace(txtb_etun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun1.Text) == true || string.IsNullOrWhiteSpace(txtb_sukun0.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv1.Text) == true || string.IsNullOrWhiteSpace(txtb_syntpv0.Text) == true)
            {
                btn_start.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
            }


        }

        //Ei anneta m
        private void Txtb_syntpv0_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtb_syntpv0.Text) < 1900 || int.Parse(txtb_syntpv0.Text) > DateTime.Now.Year && string.IsNullOrWhiteSpace(txtb_syntpv0.Text) == false)
            {
                MessageBox.Show("Syntymävuosi virheellinen", "", MessageBoxButtons.OK);
                txtb_syntpv0.Text = "";
                txtb_syntpv0.Focus();

            }
        }

        private void Txtb_syntpv1_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtb_syntpv1.Text) < 1900 || int.Parse(txtb_syntpv1.Text) > DateTime.Now.Year && string.IsNullOrWhiteSpace(txtb_syntpv1.Text) == false)
            {
                MessageBox.Show("Syntymävuosi virheellinen", "", MessageBoxButtons.OK);
                txtb_syntpv1.Text = "";
                txtb_syntpv1.Focus();

            }
        }
    }
}
