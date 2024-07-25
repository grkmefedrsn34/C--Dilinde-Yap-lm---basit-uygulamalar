using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkullanıcı.Text == "admin" && txtsifre.Text == "123456")
            {
                this.Hide(); // Form1'i gizle
                dashboard dashboardForm = new dashboard();
                dashboardForm.FormClosed += (s, args) => this.Close(); // Dashboard kapandığında Form1'i de kapat
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz !", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
