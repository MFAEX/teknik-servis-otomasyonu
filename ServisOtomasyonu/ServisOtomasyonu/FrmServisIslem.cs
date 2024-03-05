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
    public partial class FrmServisIslem : Form
    {
        public FrmServisIslem()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFiyat_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmServisIslem_Load(object sender, EventArgs e)
        {
            Genel.geri = 4;
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
