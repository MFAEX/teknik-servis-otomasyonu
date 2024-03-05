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
    public partial class frmMusterisec : Form
    {
        public frmMusterisec()
        {
            InitializeComponent();
        }

        private void frmMusterisec_Load(object sender, EventArgs e)
        {
            dataMusteri.DataSource = Genel.db.Musteri.ToList();

        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (Genel.geri==4)
            {
                FrmServisIslem frm = new FrmServisIslem();
                frm.Show();
                this.Hide();
            }
            else if (Genel.geri==3)
            {
                FrmFaturalar frm = new FrmFaturalar();
                frm.Show();
                this.Hide();
            }
            else if (Genel.geri==2)
            {
                FrmYeniKayit frm = new FrmYeniKayit();
                frm.Show();
                this.Hide();
            }
            
        }
    }
}
