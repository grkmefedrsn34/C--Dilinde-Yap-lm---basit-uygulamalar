namespace Öğrenci_Takip
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblsınıf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.cmbsınıf = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttemzile = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblsınıf);
            this.tabPage1.Controls.Add(this.lblsoyad);
            this.tabPage1.Controls.Add(this.lblad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenciler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txttemzile);
            this.tabPage2.Controls.Add(this.btnkaydet);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yeni Gelen Öğreciler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(308, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(289, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SINIF :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(408, 27);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(51, 20);
            this.lblad.TabIndex = 4;
            this.lblad.Text = "label4";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(408, 55);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(51, 20);
            this.lblsoyad.TabIndex = 5;
            this.lblsoyad.Text = "label5";
            // 
            // lblsınıf
            // 
            this.lblsınıf.AutoSize = true;
            this.lblsınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsınıf.Location = new System.Drawing.Point(408, 83);
            this.lblsınıf.Name = "lblsınıf";
            this.lblsınıf.Size = new System.Drawing.Size(51, 20);
            this.lblsınıf.TabIndex = 6;
            this.lblsınıf.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Öğreciyi Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "SOYAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "AD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "SINIF";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(113, 41);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(184, 20);
            this.txtad.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(113, 79);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(184, 20);
            this.txtsoyad.TabIndex = 4;
            // 
            // cmbsınıf
            // 
            this.cmbsınıf.FormattingEnabled = true;
            this.cmbsınıf.Items.AddRange(new object[] {
            "100",
            "101",
            "120",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119"});
            this.cmbsınıf.Location = new System.Drawing.Point(113, 117);
            this.cmbsınıf.Name = "cmbsınıf";
            this.cmbsınıf.Size = new System.Drawing.Size(184, 21);
            this.cmbsınıf.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.cmbsınıf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txttemzile
            // 
            this.txttemzile.Location = new System.Drawing.Point(151, 200);
            this.txttemzile.Name = "txttemzile";
            this.txttemzile.Size = new System.Drawing.Size(131, 38);
            this.txttemzile.TabIndex = 6;
            this.txttemzile.Text = "Temizle";
            this.txttemzile.UseVisualStyleBackColor = true;
            this.txttemzile.Click += new System.EventHandler(this.txttemzile_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(15, 200);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(119, 38);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblsınıf;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.ComboBox cmbsınıf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txttemzile;
        private System.Windows.Forms.Button btnkaydet;
    }
}