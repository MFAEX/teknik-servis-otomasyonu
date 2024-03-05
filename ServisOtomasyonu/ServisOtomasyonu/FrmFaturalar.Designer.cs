
namespace ServisOtomasyonu
{
    partial class FrmFaturalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataFaturalar = new System.Windows.Forms.DataGridView();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnKayitSec = new System.Windows.Forms.Button();
            this.btnStokSec = new System.Windows.Forms.Button();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFaturalar
            // 
            this.dataFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFaturalar.Location = new System.Drawing.Point(3, 348);
            this.dataFaturalar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataFaturalar.Name = "dataFaturalar";
            this.dataFaturalar.RowHeadersWidth = 51;
            this.dataFaturalar.RowTemplate.Height = 24;
            this.dataFaturalar.Size = new System.Drawing.Size(797, 364);
            this.dataFaturalar.TabIndex = 1;
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Image = global::ServisOtomasyonu.Properties.Resources.musteriSec;
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.Location = new System.Drawing.Point(12, 28);
            this.btnMusteriSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(184, 82);
            this.btnMusteriSec.TabIndex = 0;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnKayitSec
            // 
            this.btnKayitSec.Location = new System.Drawing.Point(12, 140);
            this.btnKayitSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayitSec.Name = "btnKayitSec";
            this.btnKayitSec.Size = new System.Drawing.Size(184, 62);
            this.btnKayitSec.TabIndex = 0;
            this.btnKayitSec.Text = "Servis Kayıt Ekle";
            this.btnKayitSec.UseVisualStyleBackColor = true;
            this.btnKayitSec.Click += new System.EventHandler(this.btnKayitSec_Click);
            // 
            // btnStokSec
            // 
            this.btnStokSec.Location = new System.Drawing.Point(15, 220);
            this.btnStokSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(181, 62);
            this.btnStokSec.TabIndex = 0;
            this.btnStokSec.Text = "Stok Seç";
            this.btnStokSec.UseVisualStyleBackColor = true;
            this.btnStokSec.Click += new System.EventHandler(this.btnStokSec_Click);
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(217, 28);
            this.txtOzet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(571, 242);
            this.txtOzet.TabIndex = 2;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Image = global::ServisOtomasyonu.Properties.Resources.yazdir;
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(427, 276);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(156, 66);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::ServisOtomasyonu.Properties.Resources.kaydet;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(637, 277);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(152, 66);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(282, 277);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 65);
            this.btnDon.TabIndex = 4;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(817, 703);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.btnStokSec);
            this.Controls.Add(this.btnKayitSec);
            this.Controls.Add(this.dataFaturalar);
            this.Controls.Add(this.btnMusteriSec);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFaturalar";
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFaturalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFaturalar;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnKayitSec;
        private System.Windows.Forms.Button btnStokSec;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnDon;
    }
}