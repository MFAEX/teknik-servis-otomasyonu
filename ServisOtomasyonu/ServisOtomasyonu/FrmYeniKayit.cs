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
    public partial class FrmYeniKayit : Form
    {
        public FrmYeniKayit()
        {
            InitializeComponent();
        }

        private void 
            
            
            
            btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri;       
            try
            {
                musteri = new Musteri()
                {
                    Unvan=txtUnvan.Text,
                    Yetkili=txtYetkili.Text,
                    GSM=txtgsm.Text,
                    Sabit=txtsabit.Text,
                    E_Mail=txtemail.Text,
                    Vergi_Dairesi=txtvergidairesi.Text,
                    Vergi_No=txtvergino.Text,
                    Sevk_Adresi=txtsevkadresi.Text,
                    Il=txtIl.Text,
                    Ilce=txtIlce.Text,
                    Posta_Kodu=txtpostakodu.Text,
                    Fatura_Adresi=txtfaturaadresi.Text
                };
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Tüm alanları doldurunuz");
                return;
            }

            Genel.db.Musteri.Add(musteri);
            Genel.db.SaveChanges();
        }
        private void FrmYeniKayit_Load(object sender, EventArgs e)
        {
            Genel.geri = 2;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=ServisOtomasyonu;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Adi_Soyadi FROM Personel";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxPersonel.Items.Add(dr["Adi_Soyadi"]);
            }
            baglanti.Close();
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            frmMusterisec frm = new frmMusterisec();
            frm.Show();
            this.Hide();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }
    }
}
