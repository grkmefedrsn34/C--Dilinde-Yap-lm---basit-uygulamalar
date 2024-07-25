using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\dersi\Ati242.WAV");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oyun bitti");
            Close();
        }

        private void MOVETOMOVE()
        {
            startSoundPlayer.Play();
            Point starttingPoint = panel1.Location;
            starttingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(starttingPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MOVETOMOVE();
        }

        private void WALLenter(object sender, EventArgs e)
        {
            MOVETOMOVE();
        }
    }
}
