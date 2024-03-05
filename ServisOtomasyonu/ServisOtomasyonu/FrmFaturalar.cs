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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Genel.geri = 3;
            dataFaturalar.DataSource = Genel.db.Fatura.ToList();

        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            frmMusterisec frm = new frmMusterisec();
            frm.Show();
            this.Hide();
        }

        private void btnKayitSec_Click(object sender, EventArgs e)
        {
            FrmServisKayitlari frm = new FrmServisKayitlari();
            frm.Show();
            this.Hide();
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStok frm = new FrmStok();
            frm.Show();
            this.Hide();
        }
    }
}
