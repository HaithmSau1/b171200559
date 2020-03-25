/**********************************************************************************************
 **                                SAKARYA ÜNİVERSİTESİ 
 **                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                         BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
 **                               NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                               2019-2020 BAHAR DÖNEMİ
 **                             
 *                                ÖDEV NUMARASI..........:1
 **                               ÖĞRENCİ ADI............: Haithm Ameen Salem Ba auozar
 **                               ÖĞRENCİ NUMARASI.......: B171200559
 **                               DERSİN ALINDIĞI GRUP...:    A
 **********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haithem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            string harf = "";
            x = (( Convert.ToDouble(textBox2.Text) * 10) / 100 ) + ((Convert.ToDouble(textBox3.Text) * 10) / 100)
                + ((Convert.ToDouble(textBox4.Text) * 30) / 100) + ((Convert.ToDouble(textBox5.Text) * 50) / 100);

            label6.Text = Convert.ToString(x);

            // AA Notu
            if (x <= 100.00 && x >= 90.00)
            {
                harf = "AA";
            }

            // BA Notu
            else if (x <= 89.99 && x >= 85.00)
            {
                harf = "BA";
            }

            // BB Notu
            else if (x <= 84.99 && x >= 80.00)
            {
                harf = "BB";
            }

            // CB Notu
            else if (x <= 79.99 && x >= 75.00)
            {
                harf = "CB";
            }

            // CC Notu
            else if (x <= 74.99 && x >= 65.00)
            {
                harf = "CC";
            }

            // DC Notu
            else if (x <= 64.99 && x >= 58.00)
            {
                harf = "DC";
            }

            // DD Notu
            else if (x <= 57.99 && x >= 50.00)
            {
                harf = "DD";
            }

            // FD Notu
            else if (x <= 49.99 && x >= 40.00)
            {
                harf = "FD";
            }

            // FF Notu
            else if (x <= 39.99 && x >= 0)
            {
                harf = "FF";
            }
            label7.Text = harf;
            MessageBox.Show("Ogrenci Adi: " + textBox1.Text + "\nNot: " + x + "\nHarf" + harf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox3.Text = "";

            textBox4.Text = "";

            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

