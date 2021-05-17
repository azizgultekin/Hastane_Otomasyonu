namespace hastaneOtomasyon
{
    partial class randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.randevuIdTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.tcRandevuTxt = new System.Windows.Forms.MaskedTextBox();
            this.cikisTxt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saatCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.randevuKaydetTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.bolumCmb = new System.Windows.Forms.ComboBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.doktorCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.monthCalendar_randevuTarihleri = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.randevuIdTxt);
            this.groupBox1.Controls.Add(this.soyadTxt);
            this.groupBox1.Controls.Add(this.tcRandevuTxt);
            this.groupBox1.Controls.Add(this.cikisTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.saatCmb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.randevuKaydetTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTarih1);
            this.groupBox1.Controls.Add(this.bolumCmb);
            this.groupBox1.Controls.Add(this.adTxt);
            this.groupBox1.Controls.Add(this.doktorCmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(244, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hastaneOtomasyon.Properties.Resources.IMS4;
            this.pictureBox2.Location = new System.Drawing.Point(433, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(211, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Seç ve Sil";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(211, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Randevu Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Randevu Id:";
            // 
            // randevuIdTxt
            // 
            this.randevuIdTxt.Enabled = false;
            this.randevuIdTxt.Location = new System.Drawing.Point(328, 18);
            this.randevuIdTxt.Name = "randevuIdTxt";
            this.randevuIdTxt.Size = new System.Drawing.Size(100, 20);
            this.randevuIdTxt.TabIndex = 47;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(328, 99);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(100, 20);
            this.soyadTxt.TabIndex = 6;
            // 
            // tcRandevuTxt
            // 
            this.tcRandevuTxt.Location = new System.Drawing.Point(328, 44);
            this.tcRandevuTxt.Mask = "00000000000";
            this.tcRandevuTxt.Name = "tcRandevuTxt";
            this.tcRandevuTxt.Size = new System.Drawing.Size(100, 20);
            this.tcRandevuTxt.TabIndex = 46;
            // 
            // cikisTxt
            // 
            this.cikisTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisTxt.Location = new System.Drawing.Point(322, 139);
            this.cikisTxt.Name = "cikisTxt";
            this.cikisTxt.Size = new System.Drawing.Size(105, 23);
            this.cikisTxt.TabIndex = 9;
            this.cikisTxt.Text = "Çıkış";
            this.cikisTxt.UseVisualStyleBackColor = true;
            this.cikisTxt.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Soyadı :";
            // 
            // saatCmb
            // 
            this.saatCmb.FormattingEnabled = true;
            this.saatCmb.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.saatCmb.Location = new System.Drawing.Point(52, 103);
            this.saatCmb.Margin = new System.Windows.Forms.Padding(2);
            this.saatCmb.Name = "saatCmb";
            this.saatCmb.Size = new System.Drawing.Size(121, 21);
            this.saatCmb.TabIndex = 3;
            this.saatCmb.SelectedIndexChanged += new System.EventHandler(this.saatCmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "TC No :";
            // 
            // randevuKaydetTxt
            // 
            this.randevuKaydetTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.randevuKaydetTxt.Location = new System.Drawing.Point(100, 139);
            this.randevuKaydetTxt.Name = "randevuKaydetTxt";
            this.randevuKaydetTxt.Size = new System.Drawing.Size(105, 23);
            this.randevuKaydetTxt.TabIndex = 8;
            this.randevuKaydetTxt.Text = "Randevu Kaydet";
            this.randevuKaydetTxt.UseVisualStyleBackColor = true;
            this.randevuKaydetTxt.Click += new System.EventHandler(this.randevuKaydetTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Saat :";
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarih1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTarih1.Image = ((System.Drawing.Image)(resources.GetObject("lblTarih1.Image")));
            this.lblTarih1.Location = new System.Drawing.Point(60, 77);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(116, 15);
            this.lblTarih1.TabIndex = 45;
            this.lblTarih1.Text = "ToLongDateString()";
            // 
            // bolumCmb
            // 
            this.bolumCmb.FormattingEnabled = true;
            this.bolumCmb.Location = new System.Drawing.Point(52, 21);
            this.bolumCmb.Name = "bolumCmb";
            this.bolumCmb.Size = new System.Drawing.Size(176, 21);
            this.bolumCmb.TabIndex = 1;
            this.bolumCmb.SelectedIndexChanged += new System.EventHandler(this.bolumCmb_SelectedIndexChanged);
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(328, 70);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 20);
            this.adTxt.TabIndex = 5;
            // 
            // doktorCmb
            // 
            this.doktorCmb.FormattingEnabled = true;
            this.doktorCmb.Location = new System.Drawing.Point(52, 47);
            this.doktorCmb.Name = "doktorCmb";
            this.doktorCmb.Size = new System.Drawing.Size(176, 21);
            this.doktorCmb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dr.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 352);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1026, 555);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 18);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(930, 558);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Bağlantı Durumu: ";
            // 
            // monthCalendar_randevuTarihleri
            // 
            this.monthCalendar_randevuTarihleri.BackColor = System.Drawing.Color.Gold;
            this.monthCalendar_randevuTarihleri.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_randevuTarihleri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar_randevuTarihleri.ForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.Location = new System.Drawing.Point(7, 6);
            this.monthCalendar_randevuTarihleri.MaxSelectionCount = 1;
            this.monthCalendar_randevuTarihleri.Name = "monthCalendar_randevuTarihleri";
            this.monthCalendar_randevuTarihleri.TabIndex = 22;
            this.monthCalendar_randevuTarihleri.TitleBackColor = System.Drawing.Color.Chocolate;
            this.monthCalendar_randevuTarihleri.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.monthCalendar_randevuTarihleri.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_randevuTarihleri_DateChanged);
            // 
            // randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1055, 582);
            this.Controls.Add(this.monthCalendar_randevuTarihleri);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyon v1-Randevu Sistemi";
            this.Load += new System.EventHandler(this.randevu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox doktorCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bolumCmb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button cikisTxt;
        private System.Windows.Forms.Button randevuKaydetTxt;
        public System.Windows.Forms.Label lblTarih1;
        public System.Windows.Forms.MonthCalendar monthCalendar_randevuTarihleri;
        private System.Windows.Forms.ComboBox saatCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tcRandevuTxt;
        private System.Windows.Forms.TextBox randevuIdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}