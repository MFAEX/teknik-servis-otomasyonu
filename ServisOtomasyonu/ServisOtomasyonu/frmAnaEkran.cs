using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisOtomasyonu
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FrmYeniKayit frm = new FrmYeniKayit();
            frm.Show();
            this.Hide();
        }

        private void btnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            frmMusteriBilgisi frm = new frmMusteriBilgisi();
            frm.Show();
            this.Hide();
        }

        private void btnServisKayitlari_Click(object sender, EventArgs e)
        {
            FrmServisKayitlari frm = new FrmServisKayitlari();
            frm.Show();
            this.Hide();
        }

        private void btnServisIslemEkle_Click(object sender, EventArgs e)
        {
            FrmServisIslem frm = new FrmServisIslem();
            frm.Show();
            this.Hide();
        }

        private void btnStokKaydi_Click(object sender, EventArgs e)
        {
            FrmStok frm = new FrmStok();
            frm.Show();
            this.Hide();
        }

        private void btnPersonelBilgisi_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgi frm = new FrmPersonelBilgi();
            frm.Show();
            this.Hide();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            FrmYeniStokEkle frm = new FrmYeniStokEkle();
            frm.Show();
            this.Hide();
        }

        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            FrmFaturalar frm = new FrmFaturalar();
            frm.Show();
            this.Hide();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            FrmAdminPanel frm = new FrmAdminPanel();
            frm.Show();
            this.Hide();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            var sonuc = Genel.db.Personel.Where(x => x.Yetki == "1" )
                .ToList();

            if (sonuc.Count==1)
            {
                btnAdminPanel.Visible = false;
            }
            
            
        }
    }
}
