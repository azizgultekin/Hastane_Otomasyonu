namespace hastaneOtomasyon
{
    partial class yapilacakislemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yapilacakislemler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.drEkraniyapilacakİslemCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.odemeIdLbl = new System.Windows.Forms.Label();
            this.fisNoLbl = new System.Windows.Forms.Label();
            this.drEkranitcTxt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC : ";
            // 
            // drEkraniyapilacakİslemCmb
            // 
            this.drEkraniyapilacakİslemCmb.FormattingEnabled = true;
            this.drEkraniyapilacakİslemCmb.Items.AddRange(new object[] {
            "Kan Tahlili",
            "İdrar Testi",
            "MR",
            "Röntgen",
            "Tomografi",
            "Covid-19 Testi",
            "Gebelik Testi",
            "Hepatit B",
            "HIV",
            "Vitamin Testi"});
            this.drEkraniyapilacakİslemCmb.Location = new System.Drawing.Point(249, 14);
            this.drEkraniyapilacakİslemCmb.Name = "drEkraniyapilacakİslemCmb";
            this.drEkraniyapilacakİslemCmb.Size = new System.Drawing.Size(121, 21);
            this.drEkraniyapilacakİslemCmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yapılacak İşlem:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(416, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Yapılacak İşlemi Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(452, 324);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Bağlantı Durumu: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 18);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 23;
            this.label4.Visible = false;
            // 
            // odemeIdLbl
            // 
            this.odemeIdLbl.AutoSize = true;
            this.odemeIdLbl.Location = new System.Drawing.Point(62, 373);
            this.odemeIdLbl.Name = "odemeIdLbl";
            this.odemeIdLbl.Size = new System.Drawing.Size(0, 13);
            this.odemeIdLbl.TabIndex = 24;
            this.odemeIdLbl.Visible = false;
            // 
            // fisNoLbl
            // 
            this.fisNoLbl.AutoSize = true;
            this.fisNoLbl.Location = new System.Drawing.Point(266, 373);
            this.fisNoLbl.Name = "fisNoLbl";
            this.fisNoLbl.Size = new System.Drawing.Size(0, 13);
            this.fisNoLbl.TabIndex = 25;
            this.fisNoLbl.Visible = false;
            // 
            // drEkranitcTxt
            // 
            this.drEkranitcTxt.Location = new System.Drawing.Point(37, 14);
            this.drEkranitcTxt.Mask = "00000000000";
            this.drEkranitcTxt.Name = "drEkranitcTxt";
            this.drEkranitcTxt.Size = new System.Drawing.Size(100, 20);
            this.drEkranitcTxt.TabIndex = 26;
            // 
            // yapilacakislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.drEkranitcTxt);
            this.Controls.Add(this.fisNoLbl);
            this.Controls.Add(this.odemeIdLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drEkraniyapilacakİslemCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yapilacakislemler";
            this.Text = "Hastane Otomasyon v1-Hasta İşlemleri";
            this.Load += new System.EventHandler(this.DoktorEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drEkraniyapilacakİslemCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label odemeIdLbl;
        private System.Windows.Forms.Label fisNoLbl;
        private System.Windows.Forms.MaskedTextBox drEkranitcTxt;
    }
}