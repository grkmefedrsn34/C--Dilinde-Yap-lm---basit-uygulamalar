namespace Pinpon_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_raket = new System.Windows.Forms.PictureBox();
            this.ptop = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_raket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_over);
            this.panel1.Controls.Add(this.lbl_Point);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptop);
            this.panel1.Controls.Add(this.p_raket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // p_raket
            // 
            this.p_raket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_raket.Location = new System.Drawing.Point(244, 371);
            this.p_raket.Name = "p_raket";
            this.p_raket.Size = new System.Drawing.Size(200, 20);
            this.p_raket.TabIndex = 0;
            this.p_raket.TabStop = false;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.Red;
            this.ptop.Location = new System.Drawing.Point(300, 215);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(30, 30);
            this.ptop.TabIndex = 1;
            this.ptop.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE :";
            // 
            // lbl_Point
            // 
            this.lbl_Point.AutoSize = true;
            this.lbl_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Point.Location = new System.Drawing.Point(160, 9);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(30, 31);
            this.lbl_Point.TabIndex = 3;
            this.lbl_Point.Text = "0";
            // 
            // lbl_over
            // 
            this.lbl_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_over.Location = new System.Drawing.Point(363, 94);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(299, 111);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "GAME OVER\r\nF-1 RESTART GAME\r\nESC EXİT\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pin-Pon Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_raket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptop;
        private System.Windows.Forms.PictureBox p_raket;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label lbl_Point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

