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
    public partial class yenikayit : Form
    {
        public yenikayit()
        {
            InitializeComponent();
        }
        MySqlConnection bag;
        MySqlCommand kmt;
        MySqlDataReader dr;
        private void yenikayit_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bag.Open();

            kmt.Connection = bag;
            
            kmt.CommandText = "INSERT INTO kayitli_hastalar(tc,dosya_no,ad,soyad,anne_adi,baba_adi,kurum) VALUES ('" + adtxt.Text + "','" + soyaditext.Text + "','" + dosyanotxt.Text + "','" + dosyanotxt.Text + "')"; 
            
            kmt.ExecuteNonQuery();
            
            kmt.Dispose();
           
            bag.Close();
        }      
    }
}
