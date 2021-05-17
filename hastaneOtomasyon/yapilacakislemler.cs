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
    public partial class yapilacakislemler : Form
    {
        public yapilacakislemler()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=hastaneotomasyonu;user=root;Pwd=1234;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        DataSet ds = new DataSet();
        public string secilenTarih;

        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                button1.BackColor = Color.Green;
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                button1.BackColor = Color.Red;
            }
        }
        void islemId()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select MAX(yapilacak_islem_id) from yapilacak_islemler", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string x = dr["max(yapilacak_islem_id)"].ToString();
                int a = int.Parse(x) + 1;
                label4.Text = a.ToString();
            }
            baglanti.Close();
        }
        public void fisNo()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select max(fis_no) from odeme", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string fisNo = dr["max(fis_no)"].ToString();
                int fisNo2 = int.Parse(fisNo) + 1;
                fisNoLbl.Text = fisNo2.ToString();
            }
            baglanti.Close();
        }
        void odemeTablosuEkle()
        {
            try
            {
                baglantiKontrol();
                string kayit = "insert into odeme(odeme_id,fis_no,tarih,tc,odeme_durumu) values(@odeme_id,@fis_no,@tarih,@tc,@odeme_durumu)";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@odeme_id", odemeIdLbl.Text);
                komut.Parameters.AddWithValue("@fis_no", fisNoLbl.Text);
                komut.Parameters.AddWithValue("@tarih", "");
                komut.Parameters.AddWithValue("@tc", drEkranitcTxt.Text);
                komut.Parameters.AddWithValue("@odeme_durumu", "Ödenmedi");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Kimlik numarasını kontrol ediniz!");
            }
        }
        void odemeId()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select MAX(odeme_id) from yapilacak_islemler", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string x = dr["max(odeme_id)"].ToString();
                int a = int.Parse(x) + 1;
                odemeIdLbl.Text = a.ToString();
            }
            baglanti.Close();
        }
        void dataDoldur()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select hastalar.tc,hastalar.adi,hastalar.soyadi,hastalar.kan_grubu,hastalar.dogum_tarihi,yapilacak_islemler.yapilacak_islem from hastalar,yapilacak_islemler where hastalar.tc like '%" + drEkranitcTxt.Text + "%' and hastalar.tc=yapilacak_islemler.tc", baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "hastalar");
            dataGridView1.DataSource = ds.Tables["hastalar"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[1].HeaderText = "Dosya No"; 
            this.dataGridView1.Columns[1].HeaderText = "Adı";
            this.dataGridView1.Columns[2].HeaderText = "Soyadı";
            this.dataGridView1.Columns[3].HeaderText = "Kan Grubu";
            this.dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            this.dataGridView1.Columns[5].HeaderText = "Yapılacak İşlem";
            baglanti.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            odemeTablosuEkle();
            try
            {
                baglantiKontrol();
                string kayit = "insert into yapilacak_islemler(yapilacak_islem,yapilacak_islem_id,yapilacak_islem_tutari,tc,odeme_id) values(@yapilacak_islem,@yapilacak_islem_id,@yapilacak_islem_tutari,@tc,@odeme_id)";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@yapilacak_islem", drEkraniyapilacakİslemCmb.Text);
                komut.Parameters.AddWithValue("@tc", drEkranitcTxt.Text);
                if (drEkraniyapilacakİslemCmb.Text == "Kan Tahlili")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "75");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "MR")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "250");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Tomografi")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "150");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Gebelik Testi")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "30");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Covid-19 Testi")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "0");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Röntgen")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "50");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "İdrar Testi")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "90");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Hepatit B")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "200");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "Vitamin Testi")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "40");
                }
                else if (drEkraniyapilacakİslemCmb.Text == "HIV")
                {
                    komut.Parameters.AddWithValue("@yapilacak_islem_tutari", "150");
                }
                else
                {
                    MessageBox.Show("Yapılacak işlemi seçiniz");
                }
                komut.Parameters.AddWithValue("@yapilacak_islem_id", label4.Text);
                komut.Parameters.AddWithValue("@odeme_id", odemeIdLbl.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla kayıt edildi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz." + hata.Message);
            }
            dataDoldur();
            islemId();
            odemeId();
            fisNo();
        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            islemId();
            odemeId();
            fisNo();

        }
    }
}
