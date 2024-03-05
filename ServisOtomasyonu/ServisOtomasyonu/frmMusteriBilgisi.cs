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
    public partial class frmMusteriBilgisi : Form
    {
        public frmMusteriBilgisi()
        {
            InitializeComponent();
        }

        private void tbxCariUnvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCariUnvan_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriBilgisi_Load(object sender, EventArgs e)
        {
            dataMusteri.DataSource = Genel.db.Musteri.ToList();

        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran();
            frm.Show();
            this.Hide();
        }
    }
}
