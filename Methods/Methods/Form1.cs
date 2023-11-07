using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Void:Değer döndürmeyen geriye anlamında
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox4.Focus();

        }
        public void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.Tan;
            textBox4.BackColor = Color.Yellow;
        }
        public void doldur() {
            textBox1.Text = "Selim";
            textBox2.Text = "Çınar";
            textBox3.Text = "Kahramanmaraş";
            textBox4.Text = "22";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doldur();
        }

        //Geriye değer döndüren return
        int toplam(int s1 ,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int carpim(int s1,int s2,int s3)
        {
            int s4 = s1 * s2*s3;
            return s4;
        }
        int küp (int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        int sum(int sayi,int sayi2)
        {
            int sonuc = sayi + sayi2;
            return sonuc;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = toplam(45, 55).ToString();
            label3.Text = toplam(55,65).ToString();
            label4.Text = toplam(105,42).ToString() ;
            label5.Text = toplam(75,21).ToString() ;
            label6.Text = toplam(21,73).ToString() ;

            int s1, s2, s3;
            s1 = Convert.ToInt32(textBox8.Text);
            s2 = Convert.ToInt32(textBox7.Text);
            s3 = Convert.ToInt32(textBox6.Text);
            label3.Text = carpim(s1 ,s2,s3).ToString();

            küp(s1);
            sum(s1, s3);
        }
    }
}
