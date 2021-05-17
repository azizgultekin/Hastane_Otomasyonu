using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace hastaneOtomasyon
{
    public partial class giris : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=hastaneotomasyonu;user=root;Pwd=1234;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        public int guvenlikKodu;
        string metinselGüvenlikKodu;
        string yenilenenMetinselGüvenlikKodu;
        public giris()
        {
            InitializeComponent();
        }
        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            if (baglanti.State == ConnectionState.Closed)
            {
            }
        }
        void kodYenile()
        {
            //https://www.bilisimogretmeni.com/visual-studio-c/c-hastane-randevu-sistemi.html sitesinden güvenlik kodu kısmı alınmıştır.
            guvenlikKodTxt.Clear();

            Random rnd_rastgeleGüvenlikKodu = new Random();

            int sayisalGüvenlikKodu;

            int[] diziGüvenlikKodu = new int[4];

            int artim = 0;

            for (int i = 1; i <= 4; i++)
            {
                sayisalGüvenlikKodu = rnd_rastgeleGüvenlikKodu.Next(1, 10);
                diziGüvenlikKodu[artim] = sayisalGüvenlikKodu;
                ++artim;
            }

            yenilenenMetinselGüvenlikKodu = diziGüvenlikKodu[0].ToString() + diziGüvenlikKodu[1].ToString() + diziGüvenlikKodu[2].ToString() + diziGüvenlikKodu[3].ToString();

            Graphics grafik = panel1.CreateGraphics();

            grafik.Clear(Color.White);

            grafik.SmoothingMode = SmoothingMode.AntiAlias;
            grafik.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.WhiteSmoke, Color.CornflowerBlue), new Rectangle(0, 0, 120, 40));

            Font drawFont = new Font("Comic Sans MS", 20, FontStyle.Bold, GraphicsUnit.Point);

            SolidBrush drawBrush = new SolidBrush(Color.White);

            grafik.DrawString(yenilenenMetinselGüvenlikKodu.ToString(), drawFont, drawBrush, 0, 0);

            grafik.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
        }
        private void girisBtn_Click(object sender, EventArgs e)
        {  
            guvenlikKodu = int.Parse(guvenlikKodTxt.Text);
            komut = new MySqlCommand();
            baglantiKontrol();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM giris where kullanici_adi='" + kAdiTxt.Text + "'AND sifre='" + sifTxt.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (((guvenlikKodu.ToString() == metinselGüvenlikKodu) || (guvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                {
                    anaekran f2 = new anaekran();
                    f2.kullaniciAdi = kAdiTxt.Text;
                    f2.Show();
                }
                else
                {
                    if (((guvenlikKodu.ToString() != metinselGüvenlikKodu) || (guvenlikKodu.ToString() != yenilenenMetinselGüvenlikKodu)))
                    {
                        errorProv_guvenlikKodTxt.SetError(guvenlikKodTxt, "Güvenlik Kodu'nu doğru giriniz.");
                        kodYenile();
                        guvenlikKodTxt.Text = "";
                    }

                    if (((guvenlikKodu.ToString() == metinselGüvenlikKodu) || (guvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                        errorProv_guvenlikKodTxt.Clear();
                }
            }
            else
            {
                if (kAdiTxt.Text == "")
                {
                    errorProv_adTxt.SetError(kAdiTxt, "Ad alanı boş bırakılamaz");
                }
                if(sifTxt.Text=="")
                {
                    errorProv_sifreTxt.SetError(sifTxt, "Şifre boş bırakılamaz");
                }
            }
            baglanti.Close();
            dr.Close(); 
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGüvenlikKoduYenile_Click(object sender, EventArgs e)
        {
            kodYenile();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grp = e.Graphics;
            grp.SmoothingMode = SmoothingMode.AntiAlias;
            grp.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.WhiteSmoke, Color.CornflowerBlue), new Rectangle(0, 0, 120, 40));

            Font drawFont = new Font("Comic Sans MS", 20, FontStyle.Bold, GraphicsUnit.Point);

            SolidBrush drawBrush = new SolidBrush(Color.White);

            grp.DrawString(metinselGüvenlikKodu.ToString(), drawFont, drawBrush, 0, 0);

            grp.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
        }
        public string yazi;
        private void giris_Load(object sender, EventArgs e)
        {
            guvenlikKodTxt.MaxLength = 4;
            Random rnd_rastgeleGüvenlikKodu = new Random();

            int sayisalGüvenlikKodu;

            int[] diziGüvenlikKodu = new int[4];

            int artim = 0;

            for (int i = 1; i <= 4; i++)
            {
                sayisalGüvenlikKodu = rnd_rastgeleGüvenlikKodu.Next(1, 10);
                diziGüvenlikKodu[artim] = sayisalGüvenlikKodu;
                ++artim;
            }

            metinselGüvenlikKodu = diziGüvenlikKodu[0].ToString() + diziGüvenlikKodu[1].ToString() + diziGüvenlikKodu[2].ToString() + diziGüvenlikKodu[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                guvenlikKodu = int.Parse(guvenlikKodTxt.Text);
                baglantiKontrol();
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                string adminKAdi = "admin";
                string adminSifre = "admin";
                komut.CommandText = "SELECT * FROM giris where kullanici_adi='" + adminKAdi + "'AND sifre='" + adminSifre + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    if (((guvenlikKodu.ToString() == metinselGüvenlikKodu) || (guvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                    {
                        adminpanel a1 = new adminpanel();
                        a1.Show();
                    }
                    else
                    {
                        if (((guvenlikKodu.ToString() != metinselGüvenlikKodu) || (guvenlikKodu.ToString() != yenilenenMetinselGüvenlikKodu)))
                        {
                            errorProv_guvenlikKodTxt.SetError(guvenlikKodTxt, "Güvenlik Kodu'nu doğru giriniz.");
                            kodYenile();
                            guvenlikKodTxt.Text = "";
                        }

                        if (((guvenlikKodu.ToString() == metinselGüvenlikKodu) || (guvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                            errorProv_guvenlikKodTxt.Clear();
                    }
                }

                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bilgileri kontrol ediniz.");
            }
        }
    }
}
