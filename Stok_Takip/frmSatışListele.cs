using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BEYZA\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();


        }

        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele();
        }
    }
}
