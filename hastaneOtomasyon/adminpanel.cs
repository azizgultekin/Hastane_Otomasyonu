using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace hastaneOtomasyon
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=hastaneotomasyonu;user=root;Pwd=1234;SslMode=none");
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
        private void button1_Click(object sender, EventArgs e)
        {
            baglantiKontrol();
            string kayit = "insert into giris(kullanici_adi,sifre) values(@kullanici_adi,@sifre)";
            MySqlCommand komut = new MySqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@kullanici_adi", adminKAdiTxt.Text);
            komut.Parameters.AddWithValue("@sifre", adminSifreTxt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı kaydedilmiştir.");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
