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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            dataStok.DataSource = Genel.db.Stok.ToList();

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
