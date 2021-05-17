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
    public partial class vezne : Form
    {
        public vezne()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=hastaneotomasyonu;user=root;Pwd=1234;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        DataSet ds = new DataSet();
        double Euro = 0.0;
        double Dolar = 0.0;
        double Rus_Rublesi = 0.0;
        double Kuveyt_Dinari = 0.0;
        double Sterlin = 0.0;
        DataSet dsDovizKur;
        public string secilenTarih;
        public float a;
        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                button7.BackColor = Color.Green;
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                button7.BackColor = Color.Red;
            }
        }
        void textTemizle()
        {
            nakitOdemeTxt.Text = "";
            nktIndirimTxt.Text = "";
            tcOdemeTxt.Text = "";
            odemeToplamTxt.Text = "";
            odenecekTutarTxt.Text = "";
            dataGridView1.ClearSelection();
            dovizCmb.Text = "";
            tlOlarakOdemeTxt.Text = "";
            indirimTxtDoviz.Text = "";
            indirimMiktariDoviz.Text = "";
            indirimMiktariKart.Text = "";
            indirimKart.Text = "";
            vadeTxt.Text = "";
            aylikTaksitTxt.Text = "";
            taksitCmb.Text = "";
            bankaCmb.Text = "";
        }
        void dataDoldur()
        {
            ds.Clear();
            string odenmedi = "Ödenmedi";
            baglantiKontrol();
            try
            {
                komut = new MySqlCommand("select hastalar.tc,hastalar.adi,hastalar.soyadi,yapilacak_islemler.yapilacak_islem,yapilacak_islemler.yapilacak_islem_tutari,odeme.fis_no,odeme.tarih from odeme,hastalar,yapilacak_islemler where odeme.tc like '%" + tcOdemeTxt.Text + "%' and odeme.odeme_durumu like '%"+odenmedi+"%' and hastalar.tc=odeme.tc and hastalar.tc=yapilacak_islemler.tc and odeme.odeme_id=yapilacak_islemler.odeme_id", baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(ds, "odeme");
                dataGridView1.DataSource = ds.Tables["odeme"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView1.Columns[3].HeaderText = "Yapılacak İşlem";
                this.dataGridView1.Columns[1].HeaderText = "Adı";
                this.dataGridView1.Columns[2].HeaderText = "Soyadı";
                this.dataGridView1.Columns[0].HeaderText = "Kimlik Numarası";
                this.dataGridView1.Columns[4].HeaderText = "Yapılacak İşlem Tutarı";
                this.dataGridView1.Columns[5].HeaderText = "Fiş Numarası";
                this.dataGridView1.Columns[6].HeaderText = "Ödeme Tarihi";
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        public float b;
        void indirimKarti()
        {
            try
            {
                baglantiKontrol();
                komut = new MySqlCommand();
                komut.CommandText = "SELECT hastalar.indirim FROM hastalar,odeme where hastalar.tc=odeme.tc and hastalar.tc=" + tcOdemeTxt.Text;
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label18.Text = dr["indirim"].ToString();
                    b = (a * 5) / 100;
                    nktIndirimTxt.Text = b.ToString();
                    indirimMiktariDoviz.Text = b.ToString();
                    indirimMiktariKart.Text = b.ToString();
                }
                baglanti.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        public void fisNo()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select fis_no from odeme where tc="+tcOdemeTxt.Text, baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                fisNoTxt.Text= dr["fis_no"].ToString();
            }
            baglanti.Close();
        }
         void DovizKur()
        {
            //https://kodmek.com/c-merkez-bankasi-doviz-kuru-cekme-kodlari.html sitesinden alıntı yapılmıştır.
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[3];
            Euro = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[14];
            Rus_Rublesi = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[8];
            Kuveyt_Dinari = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[4];
            Sterlin = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataDoldur();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            secilenTarih = e.Start.ToShortDateString();

            DateTime frm3deSecilenTarih = monthCalendar1.SelectionStart.Date;

            tarihLbl.Text = frm3deSecilenTarih.ToLongDateString();
        }

        private void tumuSecBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            odemeToplamTxt.Text = toplam.ToString();
            a = toplam + 50;
            odenecekTutarTxt.Text = a.ToString();
            indirimKarti();
            if (label18.Text == "Var")
            {
                float yeniOdenecek = a - b;
                nakitOdemeTxt.Text = yeniOdenecek.ToString();
                odenecekMiktarKartTxt.Text = yeniOdenecek.ToString();
            }
            else if (label18.Text == "Yok")
            {
                string x = odenecekTutarTxt.Text;
                nakitOdemeTxt.Text = x;
                odenecekMiktarKartTxt.Text = x;
            }
        }

        private void aramaYapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataDoldur();
                fisNo();
                indirimKarti();
                if (label18.Text == "Var")
                {
                    float yeniOdenecek = a - b;
                    nakitOdemeTxt.Text = yeniOdenecek.ToString();
                    odenecekMiktarKartTxt.Text = yeniOdenecek.ToString();
                }
                else if (label18.Text == "Yok")
                {
                    string x = odenecekTutarTxt.Text;
                    nakitOdemeTxt.Text = x;
                    odenecekMiktarKartTxt.Text = x;
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz." + hata.Message);
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nakitOdemeYapBtn_Click(object sender, EventArgs e)
        {
            if (tarihLbl.Text == "")
            {
                MessageBox.Show("Tarih seçiniz!!");
            }
            else
            {
                try
                {
                    baglantiKontrol();
                    string kayit = "UPDATE odeme SET fis_no=@fis_no,tarih=@tarih,tc=@tc,odeme_durumu=@odeme_durumu where tc=@tc";
                    komut = new MySqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@fis_no", fisNoTxt.Text);
                    komut.Parameters.AddWithValue("@tarih", tarihLbl.Text);
                    komut.Parameters.AddWithValue("@tc", tcOdemeTxt.Text);
                    komut.Parameters.AddWithValue("@odeme_durumu", "Ödendi");
                    MessageBox.Show("Ödeme işlemi gerçekleştirildi.");
                    textTemizle();
                    komut.ExecuteNonQuery();
                    dataGridView1.DataSource = null;
                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bilgi işlem ile iletişime geçiniz!"+hata.Message);
                }
            }
        }

        private void vezne_Load(object sender, EventArgs e)
        {
            tumuSecBtn.BackColor = Color.Green;
        }

        private void dovizIleOdeBtn_Click(object sender, EventArgs e)
        {
            if (tarihLbl.Text == "")
            {
                MessageBox.Show("Tarih seçiniz!!");
            }
            else
            {
                try
                {
                    baglantiKontrol();
                    string kayit = "UPDATE odeme SET fis_no=@fis_no,tarih=@tarih,tc=@tc,odeme_durumu=@odeme_durumu where fis_no=@fis_no";
                    komut = new MySqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@fis_no", fisNoTxt.Text);
                    komut.Parameters.AddWithValue("@tarih", tarihLbl.Text);
                    komut.Parameters.AddWithValue("@tc", tcOdemeTxt.Text);
                    komut.Parameters.AddWithValue("@odeme_durumu", "Ödendi");
                    MessageBox.Show("Ödeme işlemi gerçekleştirildi.");
                    textTemizle();
                    komut.ExecuteNonQuery();
                    dataGridView1.DataSource = null;
                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bilgi işlem ile iletişime geçiniz!"+hata.Message);
                }
            }
        }

        private void dovizCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DovizKur();
            if (label18.Text == "Var")
            {
                double yeniOdenecek = a - b;
                if (dovizCmb.Text == "Dolar")
                {
                    double x = yeniOdenecek / Dolar;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
                else if (dovizCmb.Text == "Euro")
                {
                    double x = yeniOdenecek / Euro;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
                else if (dovizCmb.Text == "Rus Rublesi")
                {
                    double x = yeniOdenecek / Rus_Rublesi;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
                else if (dovizCmb.Text == "Kuveyt Dinarı")
                {
                    double x = yeniOdenecek / Kuveyt_Dinari;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
                else if (dovizCmb.Text == "Sterlin")
                {
                    double x = yeniOdenecek / Sterlin;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
            }
            else if (label18.Text == "Yok")
            {
                string x = odenecekTutarTxt.Text;
                if (dovizCmb.Text == "Dolar")
                {
                    double y = Convert.ToDouble(x) / Dolar;
                    tlOlarakOdemeTxt.Text = y.ToString();
                }
                else if (dovizCmb.Text == "Euro")
                {
                    double y = Convert.ToDouble(x) / (Euro);
                    tlOlarakOdemeTxt.Text = y.ToString();
                }
                else if (dovizCmb.Text == "Rus Rublesi")
                {
                    double y = Convert.ToDouble(x) / Rus_Rublesi;
                    tlOlarakOdemeTxt.Text = y.ToString();
                }
                else if (dovizCmb.Text == "Kuveyt Dinarı")
                {
                    double y = Convert.ToDouble(x) / Kuveyt_Dinari;
                    tlOlarakOdemeTxt.Text = y.ToString();
                }
                else if (dovizCmb.Text == "Sterlin")
                {
                    double y = Convert.ToDouble(x) / Sterlin;
                    tlOlarakOdemeTxt.Text = x.ToString();
                }
            }
        }

        private void krediIleOdeBtn_Click(object sender, EventArgs e)
        {
            if (tarihLbl.Text == "")
            {
                MessageBox.Show("Tarih seçiniz!!");
            }
            else
            {
                try
                {
                    baglantiKontrol();
                    string kayit = "UPDATE odeme SET fis_no=@fis_no,tarih=@tarih,tc=@tc,odeme_durumu=@odeme_durumu where fis_no=@fis_no";
                    komut = new MySqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@fis_no", fisNoTxt.Text);
                    komut.Parameters.AddWithValue("@tarih", tarihLbl.Text);
                    komut.Parameters.AddWithValue("@tc", tcOdemeTxt.Text);
                    komut.Parameters.AddWithValue("@odeme_durumu", "Ödendi");
                    MessageBox.Show("Ödeme işlemi gerçekleştirildi.");
                    textTemizle();
                    komut.ExecuteNonQuery();
                    dataGridView1.DataSource = null;
                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bilgi işlem ile iletişime geçiniz!"+hata.Message);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bankaCmb.Text=="İş Bankası")
            {
                vadeTxt.Text = "3";
            }
            else if (bankaCmb.Text == "Vakıfbank")
            {
                vadeTxt.Text = "4";
            }
            else if (bankaCmb.Text == "Halkbank")
            {
                vadeTxt.Text = "5";
            }
            else if (bankaCmb.Text == "Ziraat Bankası")
            {
                vadeTxt.Text = "6";
            }
            else if (bankaCmb.Text == "Kuveyttürk")
            {
                vadeTxt.Text = "7";
            }
        }


        private void taksitCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(odenecekMiktarKartTxt.Text);
            double vade = Convert.ToDouble(taksitCmb.Text);
            double odenecek = n / vade;
            aylikTaksitTxt.Text = odenecek.ToString();

        }
    }
}
