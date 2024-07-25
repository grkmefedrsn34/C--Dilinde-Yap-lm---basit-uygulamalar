using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Doviz_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string para = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var XmlDosya = new XmlDocument();
            XmlDosya.Load(para);


            string dolar_alış = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;

            label1.Text = dolar_alış;

            string dolar_satış = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            label2.Text = dolar_satış;

            string euro_alış = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;

            label4.Text = euro_alış;

            string euro_satıs = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            label6.Text = euro_satıs;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = label2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = label4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = label6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(textBox1.Text);
            miktar = Convert.ToDouble(textBox2.Text);
            tutar = kur * miktar;

            textBox3.Text = tutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kur =  Convert.ToDouble(textBox1.Text);
            int miktar = Convert.ToInt32(textBox2.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            textBox3.Text =tutar.ToString();

            double kalan;

            kalan = miktar % kur;
            textBox4.Text = kalan.ToString();
        }
    }
}
