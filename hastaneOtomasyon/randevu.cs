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
    public partial class randevu : Form
    {
        public randevu()
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
        void dataDoldur()
        {
            ds.Clear();
            baglantiKontrol();
            komut = new MySqlCommand("select randevu.saat,randevu.adi,randevu.soyadi,randevu.randevu_tc,randevu.randevu_tarihi,doktor.doktor_ad_soyadi from randevu,doktor where randevu.doktor_ad_soyadi=doktor.doktor_ad_soyadi and doktor.doktor_ad_soyadi like '%" + doktorCmb.Text + "%' AND randevu.saat like '%" + saatCmb.Text + "%' AND randevu.randevu_tarihi like '%" + lblTarih1.Text + "%' ", baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[0].HeaderText = "Randevu Saati";
            this.dataGridView1.Columns[1].HeaderText = "Adı";
            this.dataGridView1.Columns[2].HeaderText = "Soyadı";
            this.dataGridView1.Columns[3].HeaderText = "Kimlik Numarası";
            this.dataGridView1.Columns[4].HeaderText = "Randevu Tarihi";
            this.dataGridView1.Columns[5].HeaderText = "Doktorun Adı";
        }
        void randevuId()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select MAX(randevu_id) from randevu", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string x = dr["max(randevu_id)"].ToString();
                int a = int.Parse(x) + 1;
                randevuIdTxt.Text = a.ToString();
            }
            baglanti.Close();
        }
        private void bolumCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCmb.Items.Clear();
            doktorCmb.Text = "";
            baglantiKontrol();
            komut = new MySqlCommand();
            komut.CommandText = "SELECT doktor_ad_soyadi FROM bolum,doktor where bolum_adi like '%" + bolumCmb.Text + "%' " + " and bolum.bolum_id = doktor.bolum_id";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktorCmb.Items.Add(dr["doktor_ad_soyadi"].ToString());
            }
            baglanti.Close();
        }
        void textTemizle()
        {
            bolumCmb.Text = "";
            doktorCmb.Text = "";
            randevuIdTxt.Text = "";
            tcRandevuTxt.Text = "";
            adTxt.Text = "";
            soyadTxt.Text = "";
            saatCmb.Text = "";
        }
        private void randevu_Load(object sender, EventArgs e)
        {
            baglantiKontrol();
            komut = new MySqlCommand();
            MySqlCommand komut2 = new MySqlCommand();
            komut.CommandText = "SELECT * FROM bolum";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                bolumCmb.Items.Add(dr["bolum_adi"]);
            }
            baglanti.Close();

            randevu frm2 = (randevu)Application.OpenForms["randevu"];

            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm2deSecilenTarih = frm2.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm2deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm2.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm2.monthCalendar_randevuTarihleri.SelectionStart;
            randevuId();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_randevuTarihleri_DateChanged(object sender, DateRangeEventArgs e)
        {
            secilenTarih = e.Start.ToShortDateString();

            DateTime frm3deSecilenTarih = monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            dataDoldur();
    }

        private void button4_Click(object sender, EventArgs e)
        {
            dataDoldur();
        }

        private void saatCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDoldur();
        }
      
        private void randevuKaydetTxt_Click(object sender, EventArgs e) 
        {
            try
            {
                baglantiKontrol();
                string kayit = "insert into randevu(randevu_id,saat,adi,soyadi,randevu_tarihi,randevu_tc,doktor_ad_soyadi) values(@randevu_id,@saat,@adi,@soyadi,@randevu_tarihi,@randevu_tc,@doktor_ad_soyadi)";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@randevu_id", randevuIdTxt.Text);
                komut.Parameters.AddWithValue("@saat", saatCmb.Text);
                komut.Parameters.AddWithValue("@adi", adTxt.Text);
                komut.Parameters.AddWithValue("@soyadi", soyadTxt.Text);
                komut.Parameters.AddWithValue("@randevu_tc", tcRandevuTxt.Text);
                komut.Parameters.AddWithValue("@randevu_tarihi", lblTarih1.Text);
                komut.Parameters.AddWithValue("@doktor_ad_soyadi", doktorCmb.Text);
                komut.ExecuteNonQuery();
                dataDoldur();
                textTemizle();
                randevuId();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz." + hata.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    baglantiKontrol();
                    komut.Connection = baglanti;
                    komut.CommandText = "DELETE FROM randevu WHERE randevu_tc='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                textTemizle();
                dataDoldur();
                randevuId();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz." + hata.Message);
            }
        }
    }
    }
