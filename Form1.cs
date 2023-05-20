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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string Cumle = "";
        string Bosluk = "";
        string Karakter = "";
        string[] KelimeDizi;
        string UzunKelime = "";
        string KisaKelime = "";
        int Uzun = 0;
        int Kisa = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> Kelimeler = new List<string>();
            List<int> Kelimelength = new List<int>();

            Bosluk = (textBox1.Text.Split(' ').Length - 1).ToString(); //Boşluk
            Cumle = (textBox1.Text.Length).ToString();//Tüm Karakterler boşuk Dahil

            Karakter = (int.Parse(Cumle) - int.Parse(Bosluk)).ToString();//Sadece Karakter

            lblBoslukDahil.Text = "Tüm Karakterler boşuk Dahil " + " / " + Cumle;
            lblKarakter.Text = "Sadece Karakter " + " / " + Karakter;
            lblBosluk.Text = "Boşluk " + " / " + Bosluk;


            KelimeDizi = textBox1.Text.Split(' ');

            for (int i = 0; i < KelimeDizi.Length; i++)
            {
                if (Cumle.Contains(KelimeDizi[i]) == false)
                {
                    Kelimeler.Add(KelimeDizi[i]);
                }
            }

            lblKelime.Text = "Kelime Sayısı " + " / " + Kelimeler.Count().ToString();//Kelime Sayısı



            foreach (var item in Kelimeler) //Uzun Kelime
            {
                if (item.Length > Uzun)
                {

                    Uzun = item.Length;
                }
                if (item.Length > 0)
                {
                    Kelimelength.Add(item.Length);
                }

            }

            Kelimelength.Sort();

            if (Kelimelength.Count > 0)
            {
                Kisa = Kelimelength[0];
            }



            lblKisa.Text = "Kisa Kelime Karakter Sayısı " + "/ " + Kisa.ToString();


            lblUzun.Text = "Uzun Kelime Karakter Sayısı " + "/ " + Uzun.ToString();




        }
    }
}
