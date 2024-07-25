using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinpon_oyunu
{
    public partial class Form1 : Form
    {
        public  int  speed_left = 4;
        public int  speed_top = 4;
        public int  points = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            p_raket.Top = panel1.Bottom - (panel1.Bottom/10);

            lbl_over.Left = (panel1.Width / 2) - (lbl_over.Width / 2);
            lbl_over.Top= (panel1.Height / 2) - (panel1.Height / 2);
            lbl_over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p_raket.Left = Cursor.Position.X - (p_raket.Width / 2);
            ptop.Left += speed_left;
            ptop.Top += speed_top;  

            if(ptop.Left < panel1.Left)
            {
                speed_left = -speed_left;
            }
            if (ptop.Right < panel1.Right)
            {
                speed_left = -speed_left;
            }
            if (ptop.Top < panel1.Top)
            {
                speed_top = -speed_top;
            }
            if (ptop.Bottom >= panel1.Bottom)
            {
                lbl_over.Visible= true;
                timer1.Enabled= false;
            }
            if(ptop.Bottom >= p_raket.Top && ptop.Bottom <= p_raket.Bottom && ptop.Left >= p_raket.Left && ptop.Right<=p_raket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                lbl_Point.Text=points.ToString();
                Random r = new Random();
                panel1.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                ptop.Top = 50;
                ptop.Left = 50;
                speed_left = 4;
                lbl_Point.Text = "0";
                timer1.Enabled = true;
                lbl_over.Visible= false;
                panel1.BackColor = Color.White;
            }
        }    
    }   
}
