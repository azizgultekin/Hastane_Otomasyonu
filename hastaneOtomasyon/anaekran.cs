using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace hastaneOtomasyon
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=hastaneotomasyonu;user=root;Pwd=1234;SslMode=none");
        MySqlCommand komut;
        MySqlDataReader dr;
        DataTable dt = new DataTable();
        public string kullaniciAdi { get; set; }
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
            baglantiKontrol();
            
            komut = new MySqlCommand("select dosya_no,tc,adi,soyadi,cinsiyet,kan_grubu,dogum_tarihi from hastalar where tc" + " like '%" + tstxtTc.Text + "%' AND adi like '%" + tsAdTxt.Text + "%' AND soyadi like '%" + tsSoyadTxt.Text + "%' order by dosya_no asc", baglanti);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "hastalar");
            dataGridView1.DataSource = ds.Tables["hastalar"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[0].HeaderText = "Dosya No";
            this.dataGridView1.Columns[1].HeaderText = "Kimlik Numarası";
            this.dataGridView1.Columns[2].HeaderText = "Adı";
            this.dataGridView1.Columns[3].HeaderText = "Soyadı";
            this.dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            this.dataGridView1.Columns[5].HeaderText = "Kan Grubu";
            this.dataGridView1.Columns[6].HeaderText = "Doğum Tarihi";
        }
        void textTemizle()
        {
            tstxtTc.Text = "";
            tsAdTxt.Text = "";
            tsSoyadTxt.Text = "";
            tsDNoTxt.Text = "";
            babaAdTxt.Text = "";
            anneAdTxt.Text = "";
            kanGrubuCmb.Text = "";
            meslekCmb.Text = "";
            esMeslekCmb.Text = "";
            dYeriTxt.Text = "";
            dTarihiTxt.Text = "";
            esAdiTxt.Text = "";
            esKanGrubuCmb.Text = "";
            referansTxt.Text = "";
            evTelTxt.Text = "";
            isTelTxt.Text = "";
            cepTelTxt.Text = "";
            faxTxt.Text = "";
            eMailTxt.Text = "";
            acilisTarihiTxt.Text = "";
            dAcanKisiTxt.Text = kullaniciAdi;
            aciklamaTxt.Text = "";
            evAdresRichTxt.Text = "";
            isAdresRichTxt.Text = "";
            varRadio.Checked = false;
            yokRadio.Checked = false;
            bekarRadio.Checked = false;
            erkekRadio.Checked = false;
            kadinRadio.Checked = false;
            dulRadio.Checked = false;
            evliRadio.Checked = false;
        }
        void dNoId()
        {
            baglantiKontrol();
            komut = new MySqlCommand("select MAX(dosya_no) from hastalar", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string x = dr["max(dosya_no)"].ToString();
                int a = int.Parse(x) + 1;
                tsDNoTxt.Text = a.ToString();
            }
            baglanti.Close();
        }
        void txtdoldur()
        {
            baglantiKontrol();
            try
            {
                string text = dataGridView1.Rows[Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["dosya_no"].Value)].Cells[0].Value.ToString();      
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM hastalar where dosya_no=" + text;
                komut.CommandType = CommandType.Text;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    tstxtTc.Text = dr["tc"].ToString();
                    tsAdTxt.Text = dr["adi"].ToString();
                    tsSoyadTxt.Text = dr["soyadi"].ToString();
                    tsDNoTxt.Text = dr["dosya_no"].ToString();
                    babaAdTxt.Text = dr["baba_adi"].ToString();
                    anneAdTxt.Text = dr["anne_adi"].ToString();
                    kanGrubuCmb.Text = dr["kan_grubu"].ToString();
                    meslekCmb.Text = dr["meslek"].ToString();
                    esMeslekCmb.Text = dr["es_meslek"].ToString();
                    dYeriTxt.Text = dr["dogum_yeri"].ToString();
                    dTarihiTxt.Text = dr["dogum_tarihi"].ToString();

                    if (dr["cinsiyet"].ToString()=="Erkek"|| dr["cinsiyet"].ToString() == "erkek")
                    {
                        erkekRadio.PerformClick();
                    }
                    else
                    {
                        kadinRadio.PerformClick();
                    }
                    if(dr["medeni_hal"].ToString() == "Evli")
                    {
                        evliRadio.PerformClick();
                    }
                    else if(dr["medeni_hal"].ToString() == "Bekar")
                    {
                        bekarRadio.PerformClick();
                    }
                    else
                    {
                        dulRadio.PerformClick();
                    }
                    esAdiTxt.Text = dr["es_ad"].ToString();
                    esKanGrubuCmb.Text = dr["es_kan_grubu"].ToString();
                    referansTxt.Text = dr["referans"].ToString();
                    evTelTxt.Text = dr["ev_tel"].ToString();
                    isTelTxt.Text = dr["is_tel"].ToString();
                    cepTelTxt.Text = dr["cep_tel"].ToString();
                    faxTxt.Text = dr["fax"].ToString();
                    eMailTxt.Text = dr["e_mail"].ToString();
                    acilisTarihiTxt.Text = dr["dosya_acilis"].ToString();
                    dAcanKisiTxt.Text = dr["dosya_acan_kisi"].ToString();
                    aciklamaTxt.Text = dr["aciklama"].ToString();
                    if (dr["indirim"].ToString()=="Var"|| dr["indirim"].ToString() == "var")
                    {
                        pictureBox1.Visible=true;
                        varRadio.PerformClick();
                    }
                    else if(dr["indirim"].ToString()=="Yok"||dr["indirim"].ToString() == "yok")
                    {
                        pictureBox1.Visible = false;
                        yokRadio.PerformClick();
                    }
                    evAdresRichTxt.Text = dr["ev_adresi"].ToString();
                    isAdresRichTxt.Text = dr["is_adresi"].ToString();
                }
                dr.Close();
            }   
                catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdoldur();
        }

        private void varRadio_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void yokRadio_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            dAcanKisiTxt.Text = kullaniciAdi;
            baglantiKontrol();
            dNoId();
            

        }

        private void tsRandevuBtn_Click(object sender, EventArgs e)
        {
            randevu f3 = new randevu();
            f3.Show();
        }

        private void tsGüncelleButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglantiKontrol();
                string kayit = "UPDATE hastalar set tc=@tc,adi=@adi,soyadi=@soyadi,anne_adi=@anne_adi,baba_adi=@baba_adi,kan_grubu=@kan_grubu,meslek=@meslek,es_meslek=@es_meslek,dogum_yeri=@dogum_yeri,dogum_tarihi=@dogum_tarihi,cinsiyet=@cinsiyet,medeni_hal=@medeni_hal,es_ad=@es_ad,es_kan_grubu=@es_kan_grubu,referans=@referans,ev_tel=@ev_tel,is_tel=@is_tel,cep_tel=@cep_tel,fax=@fax,e_mail=@e_mail,dosya_acilis=@dosya_acilis,dosya_acan_kisi=@dosya_acan_kisi,aciklama=@aciklama,indirim=@indirim,ev_adresi=@ev_adresi,is_adresi=@is_adresi where dosya_no=@dosya_no";
                komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@dosya_no", tsDNoTxt.Text);
                komut.Parameters.AddWithValue("@tc", tstxtTc.Text);
                komut.Parameters.AddWithValue("@adi", tsAdTxt.Text);
                komut.Parameters.AddWithValue("@soyadi", tsSoyadTxt.Text);
                komut.Parameters.AddWithValue("@anne_adi", anneAdTxt.Text);
                komut.Parameters.AddWithValue("@baba_adi", babaAdTxt.Text);
                komut.Parameters.AddWithValue("@kan_grubu", kanGrubuCmb.Text);
                komut.Parameters.AddWithValue("@meslek", meslekCmb.Text);
                komut.Parameters.AddWithValue("@es_meslek", esMeslekCmb.Text);
                komut.Parameters.AddWithValue("@dogum_yeri", dYeriTxt.Text);
                komut.Parameters.AddWithValue("@dogum_tarihi", dTarihiTxt.Text);

                if (erkekRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@cinsiyet", "Erkek");
                }
                else
                {
                    komut.Parameters.AddWithValue("@cinsiyet", "Kadın");
                }

                if (dulRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Dul");
                }
                else if (bekarRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Bekar");
                }
                else
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Evli");
                }

                komut.Parameters.AddWithValue("@es_ad", esAdiTxt.Text);
                komut.Parameters.AddWithValue("@es_kan_grubu", esKanGrubuCmb.Text);
                komut.Parameters.AddWithValue("@referans", referansTxt.Text);
                komut.Parameters.AddWithValue("@ev_tel", evTelTxt.Text);
                komut.Parameters.AddWithValue("@is_tel", isTelTxt.Text);
                komut.Parameters.AddWithValue("@cep_tel", cepTelTxt.Text);
                komut.Parameters.AddWithValue("@fax", faxTxt.Text);
                komut.Parameters.AddWithValue("@e_mail", eMailTxt.Text);
                komut.Parameters.AddWithValue("@dosya_acilis", acilisTarihiTxt.Text);
                komut.Parameters.AddWithValue("@dosya_acan_kisi", dAcanKisiTxt.Text);
                komut.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);

                if (varRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@indirim", "Var");
                }
                else
                {
                    komut.Parameters.AddWithValue("@indirim", "Yok");
                }

                komut.Parameters.AddWithValue("@ev_adresi", evAdresRichTxt.Text);
                komut.Parameters.AddWithValue("@is_adresi", isAdresRichTxt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz." + hata.Message);
            }
            pictureBox1.Visible = false;
            textTemizle();
            dataDoldur();
            dNoId();
        }

        private void tsKayitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglantiKontrol();
                string kayit2 = "insert into hastalar(tc,dosya_no,adi,soyadi,anne_adi,baba_adi,kan_grubu,meslek,es_meslek,dogum_yeri,dogum_tarihi,cinsiyet,medeni_hal,es_ad,es_kan_grubu,referans,ev_tel,is_tel,cep_tel,fax,e_mail,dosya_acilis,dosya_acan_kisi,aciklama,indirim,ev_adresi,is_adresi) values(@tc,@dosya_no,@adi,@soyadi,@anne_adi,@baba_adi,@kan_grubu,@meslek,@es_meslek,@dogum_yeri,@dogum_tarihi,@cinsiyet,@medeni_hal,@es_ad,@es_kan_grubu,@referans,@ev_tel,@is_tel,@cep_tel,@fax,@e_mail,@dosya_acilis,@dosya_acan_kisi,@aciklama,@indirim,@ev_adresi,@is_adresi)";
                MySqlCommand komut = new MySqlCommand(kayit2, baglanti);
                komut.Parameters.AddWithValue("@tc", tstxtTc.Text);
                komut.Parameters.AddWithValue("@dosya_no", tsDNoTxt.Text);               
                komut.Parameters.AddWithValue("@adi", tsAdTxt.Text);
                komut.Parameters.AddWithValue("@soyadi", tsSoyadTxt.Text);
                komut.Parameters.AddWithValue("@anne_adi", anneAdTxt.Text);
                komut.Parameters.AddWithValue("@baba_adi", babaAdTxt.Text);
                komut.Parameters.AddWithValue("@kan_grubu", kanGrubuCmb.Text);
                komut.Parameters.AddWithValue("@meslek", meslekCmb.Text);
                komut.Parameters.AddWithValue("@es_meslek", esMeslekCmb.Text);
                komut.Parameters.AddWithValue("@dogum_yeri", dYeriTxt.Text);
                komut.Parameters.AddWithValue("@dogum_tarihi", dTarihiTxt.Text);

                if (erkekRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@cinsiyet", "Erkek");
                }
                else
                {
                    komut.Parameters.AddWithValue("@cinsiyet", "Kadın");
                }

                if (dulRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Dul");
                }
                else if (bekarRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Bekar");
                }
                else
                {
                    komut.Parameters.AddWithValue("@medeni_hal", "Evli");
                }

                komut.Parameters.AddWithValue("@es_ad", esAdiTxt.Text);
                komut.Parameters.AddWithValue("@es_kan_grubu", esKanGrubuCmb.Text);
                komut.Parameters.AddWithValue("@referans", referansTxt.Text);
                komut.Parameters.AddWithValue("@ev_tel", evTelTxt.Text);
                komut.Parameters.AddWithValue("@is_tel", isTelTxt.Text);
                komut.Parameters.AddWithValue("@cep_tel", cepTelTxt.Text);
                komut.Parameters.AddWithValue("@fax", faxTxt.Text);
                komut.Parameters.AddWithValue("@e_mail", eMailTxt.Text);
                komut.Parameters.AddWithValue("@dosya_acilis", acilisTarihiTxt.Text);
                komut.Parameters.AddWithValue("@dosya_acan_kisi", dAcanKisiTxt.Text);
                komut.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);

                if (varRadio.Checked == true)
                {
                    komut.Parameters.AddWithValue("@indirim", "Var");
                }
                else
                {
                    komut.Parameters.AddWithValue("@indirim", "Yok");
                }

                komut.Parameters.AddWithValue("@ev_adresi", evAdresRichTxt.Text);
                komut.Parameters.AddWithValue("@is_adresi", isAdresRichTxt.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Kayıt Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bilgi işlem ile iletişime geçiniz."+hata.Message);
            }      
            pictureBox1.Visible = false;
            textTemizle();
            dataDoldur();
            dNoId();
        }

        private void aramaYap_Click(object sender, EventArgs e)
        {
            dataDoldur();
        }

        private void tsEkranBtn_Click(object sender, EventArgs e)
        {
            textTemizle();
            dNoId();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            yapilacakislemler v2 = new yapilacakislemler();
            v2.Show();
        }

        private void tsOdemeBtn_Click(object sender, EventArgs e)
        {
            vezne v1 = new vezne();
            v1.Show();
        }
    }
}
