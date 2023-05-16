using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int Bosluk = 0;
            int BoslukDahil = 0;
            int KelimeSayisi = 0;
            int uzunluk = 0;
            string UzunKelime = null;
            int Kisa = 0;
            string KisaKelime = null;



            BoslukDahil = textBox1.Text.Length;
            label1.Text = "Boşluk Dahil Karakter Sayısı " + BoslukDahil.ToString();

            string[] Kelime = textBox1.Text.Split(' ');
            KelimeSayisi = Kelime.Count();
            label2.Text = KelimeSayisi.ToString();





        int[] Kelimelength = new int[5];
            int index = 0;
            foreach (string item in Kelime)
            {
                index++;
                Kisa = item.Length;
                if (item.Length > uzunluk)
                {
                    UzunKelime = item;
                    uzunluk = item.Length;

                }
                
                    Kelimelength[index] = Kisa;
                
            }
            Array.Sort(Kelimelength);

            foreach (var item in Kelimelength)
            {
                label6.Text += item;

            }

            //for (int i = 0; i < Kelime.Length; i++)
            //{

            //}

            /*label6.Text = Kelimelength.ToString();*/ /*KisaKelime + " / " + Kisa.ToString();*/
            label5.Text = UzunKelime + " / " + uzunluk.ToString();





            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ')
                {
                    Bosluk++;
                }
            }
            label3.Text = "boşluk " + Bosluk;

            if (Bosluk > 0)
            {
                label4.Text = "Karakter Sayısı " + (BoslukDahil - Bosluk).ToString();
            }
        }
    }
}
