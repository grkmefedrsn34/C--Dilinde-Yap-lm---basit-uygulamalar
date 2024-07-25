using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Takip
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string dosyaiçerik = icerikAl();
            string path = dosyadiAl();

            if (!Directory.Exists("öğrenciler"))
            {
                Directory.CreateDirectory("öğrenciler");
            }

            File.WriteAllText(Path.Combine("öğrenciler", path), dosyaiçerik);
            MessageBox.Show("Kaydedildi");

            listBox1.Items.Add(txtad.Text + " " + txtsoyad.Text);
        }

        private string dosyadiAl()
        {
            string[] dosyalar = Directory.GetFiles("öğrenciler");
            if (dosyalar.Length == 0)
            {
                return "1.txt";
            }
            else
            {
                return (kactakaldik(dosyalar) + 1) + ".txt";
            }
        }

        private int kactakaldik(string[] dosyalar)
        {
            int ebs = 0;

            foreach (var item in dosyalar)
            {
                string sonuncu = sonuncuyual(item);
                int sonsayı = Convert.ToInt32(sonuncu.Replace(".txt", ""));
                if (sonsayı > ebs)
                {
                    ebs = sonsayı;
                }
            }
            return ebs;
        }

        private string sonuncuyual(string yol)
        {
            string[] parcala = yol.Split('\\');
            return parcala[parcala.Length - 1];
        }

        private string icerikAl()
        {
            string dosyacontent = txtad.Text;
            dosyacontent += Environment.NewLine;
            dosyacontent += txtsoyad.Text;
            dosyacontent += Environment.NewLine;
            dosyacontent += cmbsınıf.Text;
            dosyacontent += Environment.NewLine;
            dosyacontent += DateTime.Today.ToShortDateString();
            return dosyacontent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible =true;
            label3.Visible =true;

            string secilenögrenci = (string)listBox1.SelectedItem;
            string[] tumogracidosyaları = Directory.GetFiles("öğrenciler");

            foreach (var dosya in tumogracidosyaları)
            {
                string[] satırlar = File.ReadAllLines(dosya);
                if (satırlar.Length >= 2 && (satırlar[0] + " " + satırlar[1]) == secilenögrenci)
                {
                    lblad.Text = satırlar[0];
                    lblsoyad.Text = satırlar[1];
                    lblsınıf.Text = satırlar.Length > 2 ? satırlar[2] : "Bilinmiyor";
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Kimi Silmek İstediniz");
            }
            else
            {
                string secilenögrenci = (string)listBox1.SelectedItem;
                string[] tumogracidosyaları = Directory.GetFiles("öğrenciler");

                foreach (var dosya in tumogracidosyaları)
                {
                    string[] satırlar = File.ReadAllLines(dosya);
                    if (satırlar.Length >= 2 && (satırlar[0] + " " + satırlar[1]) == secilenögrenci)
                    {
                        listBox1.Items.Remove(secilenögrenci);
                        File.Delete(dosya);
                        break;
                    }
                }
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;


            lblad.Text = "";
            lblsoyad.Text = "";
            lblsınıf.Text = "";

            string[] tum_ogrenciler = Directory.GetFiles("öğrenciler");
            foreach (var item in tum_ogrenciler)
            {
                string[] satırlar = File.ReadAllLines(item);
                string ad = satırlar[0];
                string soayad = satırlar[1];
                listBox1.Items.Add(ad+" "+soayad);
            }

        }

        private void txttemzile_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtsoyad.Clear();
            cmbsınıf.Text = "";
        }
    }
}
