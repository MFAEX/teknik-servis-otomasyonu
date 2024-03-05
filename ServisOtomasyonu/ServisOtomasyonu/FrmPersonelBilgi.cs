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
    public partial class FrmPersonelBilgi : Form
    {
        public FrmPersonelBilgi()
        {
            InitializeComponent();
        }

        private void FrmPersonelBilgi_Load(object sender, EventArgs e)
        {
            dataPersonel.DataSource = Genel.db.Personel.ToList();

        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }
    }
}
