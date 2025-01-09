using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        // aloitamme tekemällä laskin näppäintä:
        private void button1_Click(object sender, EventArgs e)
        {

            // lisätään listan kuuluvat pizzat ja niihin kuuluvat kertoimet.
            double specialopera, paratiisi, americana, polamericana, kanapep, lihamestari, margherita, quattro, zorbas, perfetta, juoma1, juoma2, summa;

            // jokaisella pizzalle tehdään oma kerroin.
            double kertaa1, kertaa2, kertaa3, kertaa4, kertaa5, kertaa6, kertaa7, kertaa8, kertaa9, kertaa10, kertaa11, kertaa12;
            
            kertaa1 = double.Parse(textBox1.Text);
            kertaa2 = double.Parse(textBox2.Text);
            kertaa3 = double.Parse(textBox3.Text);
            kertaa4 = double.Parse(textBox4.Text);
            kertaa5 = double.Parse(textBox5.Text);
            kertaa6 = double.Parse(textBox6.Text);
            kertaa7 = double.Parse(textBox7.Text);
            kertaa8 = double.Parse(textBox8.Text);
            kertaa9 = double.Parse(textBox9.Text);
            kertaa10 = double.Parse(textBox10.Text);
            kertaa11 = double.Parse(textBox12.Text);
            kertaa12 = double.Parse(textBox13.Text);

            



            // muuttujat nollataan.

            specialopera = 0;
            paratiisi = 0;
            americana = 0;
            polamericana = 0;
            kanapep = 0;
            lihamestari = 0;
            margherita = 0;
            quattro = 0;
            zorbas = 0;
            perfetta = 0;
            juoma1 = 0;
            juoma2 = 0;
            summa = 0;


            // joka kerta kun laskee hinnan, niin textbox tyhjentyy.
            richTextBox1.Text = string.Empty;


            // Lisätään otsikko.
            richTextBox1.Text += "Tilauksesi:" +"\n\n";

            // Seuraavaksi on ehdot, jos checkbox on painettu, niin sen hinta ja nimi lisätään textboxiin ja tekee rivinvaihdon kahdesti.
            if ((bool)checkBox1.Checked)
            {
                specialopera = double.Parse(checkBox1.Text);  richTextBox1.Text += kertaa1 + "  | " + "Special Opera" + "\n\n"; ;
            }
            if ((bool)checkBox2.Checked)
            {
                paratiisi = double.Parse(checkBox2.Text) ; richTextBox1.Text += kertaa2 + "  | " + "Paratiisi" + "\n\n"; ;
            }
            if ((bool)checkBox3.Checked)
            {
                americana = double.Parse(checkBox3.Text); richTextBox1.Text += kertaa3 + "  | " + "Americana" + "\n\n"; ;
            }
            if ((bool)checkBox4.Checked)
            {
                polamericana = double.Parse(checkBox4.Text); richTextBox1.Text += kertaa4 + "  | " + "Pollo Americana" + "\n\n"; ;
            }
                if ((bool)checkBox5.Checked)
                {
                    kanapep = double.Parse(checkBox5.Text); richTextBox1.Text += kertaa5 + "  | " + "Kana-Pepperoni" + "\n\n"; ;
            }
                if ((bool)checkBox6.Checked)
                {
                    lihamestari = double.Parse(checkBox6.Text); richTextBox1.Text += kertaa6 + "  | " + "Lihamestari" + "\n\n"; ;
            }
                if ((bool)checkBox7.Checked)
                {
                    margherita = double.Parse(checkBox7.Text); richTextBox1.Text += kertaa7 + "  | " + "Margherita" + "\n\n"; ;
            }
                if ((bool)checkBox8.Checked)
                {
                    quattro = double.Parse(checkBox8.Text); richTextBox1.Text += kertaa8 + "  | " + "Quattro" + "\n\n"; ;
            }
                if ((bool)checkBox9.Checked)
                {
                    zorbas = double.Parse(checkBox9.Text); richTextBox1.Text += kertaa9 + "  | " + "Zorbas" + "\n\n"; ;
            }
                if ((bool)checkBox10.Checked)
                {
                    perfetta = double.Parse(checkBox10.Text); richTextBox1.Text += kertaa10 + "  | " + "Perfetta" + "\n\n"; ;
            }
                if ((bool)checkBox11.Checked)
                {
                    juoma1 = double.Parse(checkBox11.Text); richTextBox1.Text += kertaa11 + "  | " + "0,5L juoma" + "\n\n"; ;
            }
                if ((bool)checkBox12.Checked)
                {
                    juoma2 = double.Parse(checkBox12.Text); richTextBox1.Text += kertaa12 + "  | " + "1,5L juoma" + "\n\n"; ;
            }


                // kokonais summa lasketaan, jos checkbox on painettu, niin se lisätään laskuun ja jos ei ole, niin se ei ole laskussa mukana:

                summa = specialopera * kertaa1 + paratiisi * kertaa2 + americana * kertaa3 + polamericana * kertaa4 + kanapep * kertaa5 + lihamestari * kertaa6 + margherita * kertaa7 + quattro * kertaa8 + zorbas * kertaa9 + perfetta * kertaa10 + juoma1 * kertaa11 + juoma2 * kertaa12;

            // summa muutetaan merkkijonoiksi.
                textBox11.Text = summa.ToString();












        }

        // seuraavaksi tehdään Nollaus näppäin.


        private void button2_Click(object sender, EventArgs e)
        {

            

            // alla oleva koodi tarkoittaa sitä, että jos kohta ei ole tyhjä, niin se nollaa sen.
            if (textBox1.Text != string.Empty  ||
                textBox2.Text != string.Empty  ||
                textBox3.Text != string.Empty  ||
                textBox4.Text != string.Empty  ||
                textBox5.Text != string.Empty  ||
                textBox6.Text != string.Empty  ||
                textBox7.Text != string.Empty  ||
                textBox8.Text != string.Empty  ||
                textBox9.Text != string.Empty  ||
                textBox10.Text != string.Empty ||
                textBox11.Text != string.Empty ||
                checkBox1.Text != string.Empty ||
                checkBox2.Text != string.Empty || 
                checkBox3.Text != string.Empty ||
                checkBox4.Text != string.Empty ||
                checkBox5.Text != string.Empty ||
                checkBox6.Text != string.Empty ||
                checkBox7.Text != string.Empty || 
                checkBox8.Text != string.Empty ||
                checkBox9.Text != string.Empty ||
                checkBox10.Text != string.Empty||
                checkBox11.Text != string.Empty|| 
                checkBox12.Text != string.Empty)



                richTextBox1.Text = string.Empty;

            // poistaa kaikki numerot ja lisää niitten paikalle "1" ja nollaa richtextboxin.
            {
                textBox1.Text = "1";
                textBox2.Text = "1";
                textBox3.Text = "1";
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                textBox8.Text = "1";
                textBox9.Text = "1";
                textBox10.Text ="1";
                textBox11.Text = "1";
                textBox13.Text = "1";
                textBox12.Text = "1";
                richTextBox1.Text = "";


                // Painetut checkboxit nollataan takaisin alkuperäiseksi.
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                
                // Kokeen tekeminen sujui mielestäni hyvin ja olen tehnyt tämän kokeen jälkeen 44 moodle-tehtävää.


                





            }
            
        }
    }
}
