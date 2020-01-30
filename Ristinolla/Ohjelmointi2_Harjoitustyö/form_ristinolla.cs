using System;
using System.Timers;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ohjelmointi2_Harjoitustyö
{
    public partial class form_ristinolla : Form
    {
        Bitmap Isoboksi;
        int pelivuoro;
        int r1, r2, r3, r4, r5, r6, r7, r8, r9;
        int tkx1, tkx2, tky1, tky2;
        Stopwatch kello = new Stopwatch();
        System.Timers.Timer timer; 
        form_aloitusikkuna fai;

        public form_ristinolla()
        {
            InitializeComponent();
        }
        public form_ristinolla(form_aloitusikkuna f)
        {
            InitializeComponent();
            Isoboksi = new Bitmap(pcb_ristikko.Width, pcb_ristikko.Height);
            pcb_ristikko.Image = Isoboksi;
            pcb_ristikko.Paint += new PaintEventHandler(PiirraKentta);
            pcb_ristikko.MouseClick += new MouseEventHandler(RuutuClick);
            pelivuoro = 0;
            fai = f;
            VuoronMuutosFormilla();
           
            r1 = 2;
            r2 = 2;
            r3 = 2;
            r4 = 2;
            r5 = 2;
            r6 = 2;
            r7 = 2;
            r8 = 2;
            r9 = 2;

        }

        //Näytetään pelikentän yllä pelaajien nimet
        private void Form_ristinolla_Load(object sender, EventArgs e)
        {
            lbl_nimi0.Text = fai.pelaaja0.etunimi + " " + fai.pelaaja0.sukunimi;
            if (fai.check == 1)
            {
                lbl_nimi1.Text = "Tietokone";
                this.Text = "Ristinolla | " + fai.pelaaja0.etunimi + " vs. Tietokone";
            }
            else
            {
                lbl_nimi1.Text = fai.pelaaja1.etunimi + " " + fai.pelaaja1.sukunimi;
                this.Text = "Ristinolla | " + fai.pelaaja0.etunimi + " vs. " + fai.pelaaja1.etunimi;
            }

            kello.Start();
        }

        private void PiirraKentta(object sender, PaintEventArgs e)
        {

            using (Pen p = new Pen(Color.Black, 2))
            {

                //Käytetään pictureboksin mittoja niin ei tarvi temppuilla jos muuttelen kokoa.
                e.Graphics.DrawLine(p, pcb_ristikko.Width / 3, 0, pcb_ristikko.Width / 3, pcb_ristikko.Height);
                e.Graphics.DrawLine(p, pcb_ristikko.Width / 3 * 2, 0, pcb_ristikko.Width / 3 * 2, pcb_ristikko.Height);
                e.Graphics.DrawLine(p, 0, pcb_ristikko.Height / 3, pcb_ristikko.Width, pcb_ristikko.Height / 3);
                e.Graphics.DrawLine(p, 0, pcb_ristikko.Height / 3 * 2, pcb_ristikko.Width, pcb_ristikko.Height / 3 * 2);

            }

        }


        //Tarkistetään kenen vuorolla klikataan, ja mitä ruutua.
        private void RuutuClick(object sender, MouseEventArgs e)
        {
            


            switch (pelivuoro)
            {

                case 0:
                    //Ylärivi vasen
                    if (e.X <= pcb_ristikko.Width / 3 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r1 == 2)
                        {

                            pelivuoro = 1;

                            PiirraYmpyra(7, pcb_ristikko.Width / 3 - 15, 7, pcb_ristikko.Height / 3 - 15);

                            r1 = 0;
                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }

                        }
                    }

                    //Ylärivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r2 == 2)
                        {

                           pelivuoro = 1;
                            r2 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 - 15, 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Ylärivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r3 == 2)
                        {

                            pelivuoro = 1;
                            r3 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width / 3 - 15, 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Keskirivi vasen
                    else if (e.X <= pcb_ristikko.Width / 3 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r4 == 2)
                        {
  
                            pelivuoro = 1;
                            r4 = 0;

                            PiirraYmpyra(7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Keskirivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r5 == 2)
                        {

                            pelivuoro = 1;
                            r5 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                           
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Keskirivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r6 == 2)
                        {

                            pelivuoro = 1;
                            r6 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Alarivi vasen
                    else if (e.X <= pcb_ristikko.Width / 3 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r7 == 2)
                        {

                            pelivuoro = 1;
                            r7 = 0;

                            PiirraYmpyra(7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Alarivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r8 == 2)
                        {

                            pelivuoro = 1;
                            r8 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    //Alarivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r9 == 2)
                        {

                            pelivuoro = 1;
                            r9 = 0;

                            PiirraYmpyra(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width / 3 - 15, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height / 3 - 15);

                            TarkistaPaatos();
                            
                            VuoronMuutosFormilla();
                            if (fai.check == 1)
                            {
                                TietoKonePelaa();
                            }
                        }
                    }

                    break;

                case 1:


                    if(fai.check == 1)
                    {

                    }
                    //ylärivi vasen
                    else if (e.X <= pcb_ristikko.Width / 3 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r1 == 2)
                        {

                            pelivuoro = 0;
                            r1 = 1;

                            PiirraRuksi(7, pcb_ristikko.Width / 3 - 7, 7, pcb_ristikko.Height / 3 - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                            
                        }
                    }

                    //Ylärivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r2 == 2)
                        {

                            pelivuoro = 0;
                            r2 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 * 2 - 7, 7, pcb_ristikko.Height / 3 - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Ylärivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3)
                    {
                        if (r3 == 2)
                        {

                            pelivuoro = 0;
                            r3 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width - 7, 7, pcb_ristikko.Height / 3 - 7);


                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Keskirivi vasen
                    else if (e.X <= pcb_ristikko.Width / 3 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r4 == 2)
                        {

                            pelivuoro = 0;
                            r4 = 1;

                            PiirraRuksi(7, pcb_ristikko.Width / 3 - 7, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 * 2 - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Keskirivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r5 == 2)
                        {

                            pelivuoro = 0;
                            r5 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 * 2 - 7, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 * 2 - 7);


                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Keskirivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y <= pcb_ristikko.Height / 3 * 2)
                    {
                        if (r6 == 2)
                        {

                            pelivuoro = 0;
                            r6 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width - 7, pcb_ristikko.Height / 3 + 7, pcb_ristikko.Height / 3 * 2 - 7);


                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Alarivi vasen
                    else if (e.X <= pcb_ristikko.Width / 3 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r7 == 2)
                        {

                            pelivuoro = 0;
                            r7 = 1;

                            PiirraRuksi(7, pcb_ristikko.Width / 3 - 7, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Alarivi keski
                    else if (e.X <= pcb_ristikko.Width / 3 * 2 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r8 == 2)
                        {

                            pelivuoro = 0;
                            r8 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 + 7, pcb_ristikko.Width / 3 * 2 - 7, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }

                    //Alarivi oikea
                    else if (e.X > pcb_ristikko.Width / 3 * 2 && e.Y > pcb_ristikko.Height / 3 * 2)
                    {
                        if (r9 == 2)
                        {

                            pelivuoro = 0;
                            r9 = 1;

                            PiirraRuksi(pcb_ristikko.Width / 3 * 2 + 7, pcb_ristikko.Width - 7, pcb_ristikko.Height / 3 * 2 + 7, pcb_ristikko.Height - 7);

                            TarkistaPaatos();
                            VuoronMuutosFormilla();
                        }
                    }


                    break;
            }


            
        }




        //Piirretään X oikeaan paikkaan
        private void PiirraRuksi(int x1, int x2, int y1, int y2)
        {
            using (Graphics g = pcb_ristikko.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.Blue, 6))
                {
                    g.DrawLine(pen, x1, y1, x2, y2);
                    g.DrawLine(pen, x1, y2, x2, y1);
                    //g.Dispose();
                    //pen.Dispose();
                }
            }

        }
        //Piirretään O oikeaan paikkaan
        private void PiirraYmpyra(int x1, int x2, int y1, int y2)
        {
            using (Graphics g = pcb_ristikko.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.Red, 6))
                {
                    g.DrawEllipse(pen, new Rectangle(x1, y1, x2, y2));
                    //g.Dispose();
                    //pen.Dispose();
                }
            }
        }

        //Muutetaan "vuoroindikaattorit" oikeille kohdilleen
        private void VuoronMuutosFormilla()
        {
            switch (pelivuoro)
            {
                case 0:
                    lbl_aktvuoro0.Visible = true;
                    lbl_aktvuoro1.Visible = false;
                    pnl_pelaaja0.BackColor = Color.LimeGreen;
                    pnl_pelaaja1.BackColor = Color.White;
                    break;

                case 1:
                    lbl_aktvuoro1.Visible = true;
                    lbl_aktvuoro0.Visible = false;
                    pnl_pelaaja1.BackColor = Color.LimeGreen;
                    pnl_pelaaja0.BackColor = Color.White;
                    break;

            }
        }
        /*Tarkistetaan onko päätös suoritettu, päivitetään pelaajatiedot, Kysytään halutaanko pelata uudestaan. Jos halutaan "resetoidaan"
         kenttä, jos ei, sammutetaan ohjelma. */
        public void TarkistaPaatos()
        {
            DialogResult dr;
            dr = DialogResult.None;
            MessageBoxButtons napit = MessageBoxButtons.YesNo;

            double aikasek = kello.ElapsedMilliseconds / 1000;
            


            // form_aloitusikkuna fai = new form_aloitusikkuna();




            //Tarkistetaan onko jokin rivi samaa merkkiä
            if (r1 == r2 && r2 == r3 && r2 != 2)
            {


                switch (r2)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;
                        
                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;

                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;
                         
                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r1 == r5 && r5 == r9 && r5 != 2)
            {


                switch (r5)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r1 == r4 && r4 == r7 && r4 != 2)
            {

                switch (r4)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r2 == r5 && r5 == r8 && r5 != 2)
            {

                switch (r5)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r3 == r5 && r5 == r7 && r5 != 2)
            {

                switch (r5)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r3 == r6 && r6 == r9 && r6 != 2)
            {

                switch (r3)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r4 == r5 && r5 == r6 && r5 != 2)
            {

                switch (r5)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            else if (r7 == r8 && r8 == r9 && r8 != 2)
            {

                switch (r7)
                {
                    case 0:
                        dr = MessageBox.Show("Ympyrällä pelaava voitti.\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja0.voitot++;
                        fai.pelaaja1.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;

                    case 1:
                        dr = MessageBox.Show("Ruksilla pelaava voitti \nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                        fai.pelaaja1.voitot++;
                        fai.pelaaja0.tappiot++;

                        fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                        fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
                        break;
                }
            }
            //kaikki käytetty, mutta mikään rivi ei ole täynnä samoja
            else if (r1 != 2 && r2 != 2 && r3 != 2 && r4 != 2 && r5 != 2 && r6 != 2 && r7 != 2 && r8 != 2 && r9 != 2)
            {

                dr = MessageBox.Show("Tasapeli\nHaluatko pelata uudestaan?", "Peli päättynyt", napit);
                fai.pelaaja1.tasapelit++;
                fai.pelaaja0.tasapelit++;

                fai.pelaaja0.peliaika = fai.pelaaja0.peliaika + aikasek;
                fai.pelaaja1.peliaika = fai.pelaaja1.peliaika + aikasek;
            }

            switch (dr)
            {
                case DialogResult.No:
                    this.DialogResult = DialogResult.OK;
                    r1 = 2;
                    r2 = 2;
                    r3 = 2;
                    r4 = 2;
                    r5 = 2;
                    r6 = 2;
                    r7 = 2;
                    r8 = 2;
                    r9 = 2;
                    this.Close();


                    break;
                //Resetoidaan pelikenttä ja "käytetyt" ruudut
                case DialogResult.Yes:
                    r1 = 2;
                    r2 = 2;
                    r3 = 2;
                    r4 = 2;
                    r5 = 2;
                    r6 = 2;
                    r7 = 2;
                    r8 = 2;
                    r9 = 2;
                    this.Refresh();
                    pcb_ristikko.Invalidate();

                    VuoronMuutosFormilla();
                    kello.Restart();

                    break;


            }


        }

        //AI:n vuoro. kun aika loppuu, siirrytään toiseen funktioon
        private void TietoKonePelaa()
        {
            Random rng = new Random();
            int valitturuutu, ajastinrng;
            bool kelpaa = false;
            timer = new System.Timers.Timer();

            //Ei anneta "AI"n valita olemassaolevaa ruutua, Määritetään koordinaatit piirrolle kuten pelaajan valitessa...
            while (kelpaa == false)
            {
                valitturuutu = rng.Next(1, 10);

                switch (valitturuutu)
                {

                    case 1:
                        if (r1 == 2)
                        {
                            kelpaa = true;
                            tkx1 = 7;
                            tkx2 = pcb_ristikko.Width / 3 - 7;
                            tky1 = 7;
                            tky2 = pcb_ristikko.Height / 3 - 7;
                            r1 = 1;
 

                        }
                        break;
                    case 2:
                        if (r2 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 + 7;
                            tkx2 = pcb_ristikko.Width / 3 * 2 -7;
                            tky1 = 7;
                            tky2 = pcb_ristikko.Height / 3 - 7;
                            r2 = 1;


                        }
                        break;
                    case 3:
                        if (r3 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 * 2 + 7;
                            tkx2 = pcb_ristikko.Width - 7;
                            tky1 = 7;
                            tky2 = pcb_ristikko.Height / 3 - 7;
                            r3 = 1;
                            
                        }
                        break;
                    case 4:
                        if (r4 == 2)
                        {
                            kelpaa = true;
                            tkx1 = 7;
                            tkx2 = pcb_ristikko.Width / 3 - 7;
                            tky1 = pcb_ristikko.Height / 3 + 7;
                            tky2 = pcb_ristikko.Height / 3 * 2 - 7;
                            r4 = 1;


                        }
                        break;
                    case 5:
                        if (r5 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 + 7;
                            tkx2 = pcb_ristikko.Width / 3 * 2 - 7;
                            tky1 = pcb_ristikko.Height / 3 + 7;
                            tky2 = pcb_ristikko.Height / 3 * 2 - 7;
                            r5 = 1;

                        }

                        break;
                    case 6:
                        if (r6 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 * 2 + 7;
                            tkx2 = pcb_ristikko.Width - 7;
                            tky1 = pcb_ristikko.Height / 3 + 7;
                            tky2 = pcb_ristikko.Height / 3 * 2 - 7;
                            r6 = 1;


                        }
                        break;
                    case 7:
                        if (r7 == 2)
                        {
                            kelpaa = true;
                            tkx1 = 7;
                            tkx2 = pcb_ristikko.Width / 3 - 7;
                            tky1 = pcb_ristikko.Height / 3 * 2 + 7;
                            tky2 = pcb_ristikko.Height - 7;
                            r7 = 1;


                        }
                        break;
                    case 8:
                        if (r8 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 + 7;
                            tkx2 = pcb_ristikko.Width / 3 * 2 - 7;
                            tky1 = pcb_ristikko.Height / 3 * 2 + 7;
                            tky2 = pcb_ristikko.Height - 7;
                            r8 = 1;


                        }
                        break;
                    case 9:
                        if (r9 == 2)
                        {
                            kelpaa = true;
                            tkx1 = pcb_ristikko.Width / 3 * 2 + 7;
                            tkx2 = pcb_ristikko.Width - 7;
                            tky1 = pcb_ristikko.Height / 3 * 2 + 7;
                            tky2 = pcb_ristikko.Height - 7;
                            r9 = 1;


                        }
                        break;
                }
            }
            ajastinrng = rng.Next(500, 2001);
            
            timer.Interval = ajastinrng;
            timer.Elapsed += new ElapsedEventHandler(TKVuoroPaatos);
            timer.Start();
            
            
        }
        //Piirretään ruksi, vaihdetaan vuoro formilla ja koodissa.
        private void TKVuoroPaatos(object source, ElapsedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            pelivuoro = 0;
            PiirraRuksi(tkx1, tkx2, tky1, tky2);

            TarkistaPaatos();
            VuoronMuutosFormilla();

        }
    }
}
