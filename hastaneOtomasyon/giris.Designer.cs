namespace hastaneOtomasyon
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.sifTxt = new System.Windows.Forms.TextBox();
            this.kAdiLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guvenlikKoduYenileBtn = new System.Windows.Forms.Button();
            this.lblGüvenlikKodu = new System.Windows.Forms.Label();
            this.picBoxGüvenlikKoduSimgesi = new System.Windows.Forms.PictureBox();
            this.picBoxAd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kAdiTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guvenlikKodTxt = new System.Windows.Forms.TextBox();
            this.errorProv_guvenlikKodTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProv_adTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProv_sifreTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGüvenlikKoduSimgesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_guvenlikKodTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_adTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_sifreTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // sifTxt
            // 
            this.sifTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifTxt.Location = new System.Drawing.Point(151, 224);
            this.sifTxt.Multiline = true;
            this.sifTxt.Name = "sifTxt";
            this.sifTxt.PasswordChar = '*';
            this.sifTxt.Size = new System.Drawing.Size(125, 25);
            this.sifTxt.TabIndex = 2;
            // 
            // kAdiLbl
            // 
            this.kAdiLbl.AutoSize = true;
            this.kAdiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiLbl.Location = new System.Drawing.Point(29, 190);
            this.kAdiLbl.Name = "kAdiLbl";
            this.kAdiLbl.Size = new System.Drawing.Size(88, 17);
            this.kAdiLbl.TabIndex = 2;
            this.kAdiLbl.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // girisBtn
            // 
            this.girisBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisBtn.Location = new System.Drawing.Point(192, 327);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(56, 27);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.Location = new System.Drawing.Point(263, 328);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(56, 27);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hastaneOtomasyon.Properties.Resources.IMS4;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guvenlikKoduYenileBtn);
            this.panel2.Controls.Add(this.lblGüvenlikKodu);
            this.panel2.Location = new System.Drawing.Point(21, 267);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 33);
            this.panel2.TabIndex = 19;
            // 
            // guvenlikKoduYenileBtn
            // 
            this.guvenlikKoduYenileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guvenlikKoduYenileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guvenlikKoduYenileBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guvenlikKoduYenileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guvenlikKoduYenileBtn.BackgroundImage")));
            this.guvenlikKoduYenileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guvenlikKoduYenileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guvenlikKoduYenileBtn.Location = new System.Drawing.Point(100, 6);
            this.guvenlikKoduYenileBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guvenlikKoduYenileBtn.Name = "guvenlikKoduYenileBtn";
            this.guvenlikKoduYenileBtn.Size = new System.Drawing.Size(29, 20);
            this.guvenlikKoduYenileBtn.TabIndex = 6;
            this.guvenlikKoduYenileBtn.UseVisualStyleBackColor = false;
            this.guvenlikKoduYenileBtn.Click += new System.EventHandler(this.btnGüvenlikKoduYenile_Click);
            // 
            // lblGüvenlikKodu
            // 
            this.lblGüvenlikKodu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGüvenlikKodu.AutoSize = true;
            this.lblGüvenlikKodu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGüvenlikKodu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGüvenlikKodu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGüvenlikKodu.Location = new System.Drawing.Point(1, 7);
            this.lblGüvenlikKodu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGüvenlikKodu.Name = "lblGüvenlikKodu";
            this.lblGüvenlikKodu.Size = new System.Drawing.Size(95, 16);
            this.lblGüvenlikKodu.TabIndex = 17;
            this.lblGüvenlikKodu.Text = "Güvenlik Kodu:";
            // 
            // picBoxGüvenlikKoduSimgesi
            // 
            this.picBoxGüvenlikKoduSimgesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picBoxGüvenlikKoduSimgesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxGüvenlikKoduSimgesi.BackgroundImage")));
            this.picBoxGüvenlikKoduSimgesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxGüvenlikKoduSimgesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxGüvenlikKoduSimgesi.Location = new System.Drawing.Point(263, 267);
            this.picBoxGüvenlikKoduSimgesi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxGüvenlikKoduSimgesi.Name = "picBoxGüvenlikKoduSimgesi";
            this.picBoxGüvenlikKoduSimgesi.Size = new System.Drawing.Size(33, 33);
            this.picBoxGüvenlikKoduSimgesi.TabIndex = 34;
            this.picBoxGüvenlikKoduSimgesi.TabStop = false;
            // 
            // picBoxAd
            // 
            this.picBoxAd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxAd.BackgroundImage")));
            this.picBoxAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAd.Location = new System.Drawing.Point(122, 186);
            this.picBoxAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxAd.Name = "picBoxAd";
            this.picBoxAd.Size = new System.Drawing.Size(32, 25);
            this.picBoxAd.TabIndex = 35;
            this.picBoxAd.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(167, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 33);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kAdiTxt
            // 
            this.kAdiTxt.Location = new System.Drawing.Point(151, 186);
            this.kAdiTxt.Multiline = true;
            this.kAdiTxt.Name = "kAdiTxt";
            this.kAdiTxt.Size = new System.Drawing.Size(125, 25);
            this.kAdiTxt.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 25);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // guvenlikKodTxt
            // 
            this.guvenlikKodTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikKodTxt.Location = new System.Drawing.Point(294, 267);
            this.guvenlikKodTxt.Multiline = true;
            this.guvenlikKodTxt.Name = "guvenlikKodTxt";
            this.guvenlikKodTxt.Size = new System.Drawing.Size(99, 34);
            this.guvenlikKodTxt.TabIndex = 3;
            // 
            // errorProv_guvenlikKodTxt
            // 
            this.errorProv_guvenlikKodTxt.ContainerControl = this;
            // 
            // errorProv_adTxt
            // 
            this.errorProv_adTxt.ContainerControl = this;
            // 
            // errorProv_sifreTxt
            // 
            this.errorProv_sifreTxt.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telif hakları saklıdır.";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(79, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 40;
            this.button1.Text = "Admin Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giris
            // 
            this.AcceptButton = this.girisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guvenlikKodTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kAdiTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxAd);
            this.Controls.Add(this.picBoxGüvenlikKoduSimgesi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kAdiLbl);
            this.Controls.Add(this.sifTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyon v1-Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGüvenlikKoduSimgesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_guvenlikKodTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_adTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv_sifreTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sifTxt;
        private System.Windows.Forms.Label kAdiLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button guvenlikKoduYenileBtn;
        public System.Windows.Forms.Label lblGüvenlikKodu;
        public System.Windows.Forms.PictureBox picBoxGüvenlikKoduSimgesi;
        public System.Windows.Forms.PictureBox picBoxAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kAdiTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox guvenlikKodTxt;
        private System.Windows.Forms.ErrorProvider errorProv_guvenlikKodTxt;
        private System.Windows.Forms.ErrorProvider errorProv_adTxt;
        private System.Windows.Forms.ErrorProvider errorProv_sifreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

