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



        int BoslukDahil = 0;
        int KelimeSayisi = 0;
        int uzunluk = 0;
        string UzunKelime = null;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            BoslukDahil = textBox1.Text.Length;
            label1.Text = "Boşluk Dahil Karakter Sayısı " + BoslukDahil.ToString();

           
           

            List<string> Kelimeler = new List<string>();

            int Bosluk = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ')
                {
                    Bosluk++;
                    Kelimeler.Add(textBox1.Text[i].ToString());
                }
               


            }
            label3.Text = "boşluk " + Bosluk;

            label2.Text = "Kelime Sayısı " + Kelimeler.Count().ToString();

            if (Bosluk > 0)
            {
                label4.Text = "Karakter Sayısı " + (BoslukDahil - Bosluk).ToString();
            }



            string[] Kelime = textBox1.Text.Split(' ');

            List<int> Kelimelength = new List<int>();

            foreach (string item in Kelime)
            {


                if (item.Length > uzunluk)
                {
                   // UzunKelime = item;
                    uzunluk = item.Length;

                }

                Kelimelength.Add(item.Length);

            }

            Kelimelength.Sort();


            for (int i = 0; i < Kelimelength.Count; i++)
            {
                if (Kelimelength[i] > 0)
                {
                    label6.Text = "En kısa Kelime/Karakter sayısı= " + Kelimelength[i].ToString();
                    break;
                }
            }


            label5.Text = /*UzunKelime + " / "*/ "En Uzun Kelime/Karakter sayısı= " + uzunluk.ToString();



        }
    }
}
