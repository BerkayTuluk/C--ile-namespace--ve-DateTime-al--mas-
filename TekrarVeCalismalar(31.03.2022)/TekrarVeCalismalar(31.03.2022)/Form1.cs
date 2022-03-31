using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DogumTarih;
using YasHesaplama;

namespace TekrarVeCalismalar_31._03._2022_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi1 = int.Parse(textBox1.Text);
            //int sayi2 = int.Parse(textBox2.Text);
            //Deger deger = new Deger();
            //deger.İslem(sayi1,sayi2);
            DateTime dateTime = DateTime.Now;
            string Tarih = dateTime.ToString();

            DateTime Tari1 = Convert.ToDateTime(textBox1.Text);
            DateTime Tari2 = Convert.ToDateTime(textBox2.Text);
            Deger deger = new Deger();
            deger.İslem(Tari1, Tari2);
            Yass yass = new Yass();
            yass.YassHesaplama(Tari1, Tari2);
        }
    }
}

namespace DogumTarih
{
    public class Deger
    {
        public Deger()
        {

        }

        public void İslem(DateTime a, DateTime b)
        {
            if (a > b)
            {
                MessageBox.Show($"Büyük Tarih: {a.ToLongDateString()}");
                
            }
            else
            {
                MessageBox.Show($"Büyük Tarih : {b.ToLongDateString()}");
            }

        }
    }
}

namespace YasHesaplama
{
    public class Yass
    {
        public Yass()
        {

        }

        public void YassHesaplama(DateTime a, DateTime b)
        {
            DateTime degerler = DateTime.Now;
            string Tarih = degerler.ToString();
            TimeSpan sonuc;
            
            if(a > b)
            {
                sonuc = degerler - a;
                Tarih = (sonuc.TotalDays / 360).ToString("0");//yaşın tam dğerinin almamızı sağlar
                MessageBox.Show($"Yaşınız: {Tarih}");
            }
            else
            {
                sonuc= degerler - b;
                Tarih = (sonuc.TotalDays / 360).ToString("0");
                MessageBox.Show($"Yaşınız: {Tarih}");
            }
        }
    }
}
