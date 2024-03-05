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
    public partial class FrmServisKayitlari : Form
    {
        public FrmServisKayitlari()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmServisKayitlari_Load(object sender, EventArgs e)
        {
            
            dataKayit.DataSource = Genel.db.Cihaz.ToList();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            if (Genel.geri==3)
            {
                FrmFaturalar frm = new FrmFaturalar();
                frm.Show();
                this.Hide();
            }
        }
    }
}
