using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServisOtomasyonu
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            dataPersonel.DataSource = Genel.db.Personel.ToList();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=ServisOtomasyonu;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Birim FROM Personel";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbxBirim.Items.Add(dr["Birim"]);
            }
            baglanti.Close();
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = "Data Source=.;Initial Catalog=ServisOtomasyonu;Integrated Security=SSPI";
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "SELECT MagazaAdi FROM Magaza";
            komut2.Connection = baglanti2;
            komut2.CommandType = CommandType.Text;
            SqlDataReader dr2;
            baglanti2.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbxMagaza.Items.Add(dr2["MagazaAdi"]);
            }
            baglanti2.Close();
            SqlConnection baglanti3 = new SqlConnection();
            baglanti3.ConnectionString = "Data Source=.;Initial Catalog=ServisOtomasyonu;Integrated Security=SSPI";
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "SELECT Yetki FROM Personel";
            komut3.Connection = baglanti3;
            komut3.CommandType = CommandType.Text;
            SqlDataReader dr3;
            baglanti3.Open();
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbxYetki.Items.Add(dr3["Yetki"]);
            }
            baglanti3.Close();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }
    }
}
