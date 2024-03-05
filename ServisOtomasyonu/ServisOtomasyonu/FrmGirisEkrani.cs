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
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sonuc = Genel.db.Personel.Where(x => x.Magaza == cmbxMagaza.SelectedItem.ToString() && x.Sifre == txtSifre.Text && x.Personel_No.ToString()==txtPersonelNo.Text)
               .ToList();

            if (sonuc.Count == 1)
            {
                frmAnaEkran frm = new frmAnaEkran();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                txtPersonelNo.Clear();
                txtSifre.Clear();
            }
        }

        private void FrmGirisEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=ServisOtomasyonu;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT MagazaAdi FROM Magaza";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbxMagaza.Items.Add(dr["MagazaAdi"]);
            }
            baglanti.Close();
        }
    }
}
