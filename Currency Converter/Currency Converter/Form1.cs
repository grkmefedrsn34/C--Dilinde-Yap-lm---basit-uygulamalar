using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.ar/search?q=1+usd+to+ars");
        }
    }
}
