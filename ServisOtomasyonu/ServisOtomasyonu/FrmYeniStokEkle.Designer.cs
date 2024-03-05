
namespace ServisOtomasyonu
{
    partial class FrmYeniStokEkle
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
            this.gbStok = new System.Windows.Forms.GroupBox();
            this.cmbxKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblStokFiyat = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.gbStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStok
            // 
            this.gbStok.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbStok.Controls.Add(this.cmbxKategori);
            this.gbStok.Controls.Add(this.label5);
            this.gbStok.Controls.Add(this.txtStok);
            this.gbStok.Controls.Add(this.lblStokFiyat);
            this.gbStok.Controls.Add(this.txtStokMiktari);
            this.gbStok.Controls.Add(this.lblStokMiktari);
            this.gbStok.Controls.Add(this.txtStokAdi);
            this.gbStok.Controls.Add(this.lblStokAdi);
            this.gbStok.Controls.Add(this.txtStokKodu);
            this.gbStok.Controls.Add(this.lblStokKodu);
            this.gbStok.Location = new System.Drawing.Point(12, 12);
            this.gbStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStok.Name = "gbStok";
            this.gbStok.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStok.Size = new System.Drawing.Size(321, 203);
            this.gbStok.TabIndex = 0;
            this.gbStok.TabStop = false;
            this.gbStok.Text = "Stok Ekle";
            // 
            // cmbxKategori
            // 
            this.cmbxKategori.FormattingEnabled = true;
            this.cmbxKategori.Location = new System.Drawing.Point(117, 139);
            this.cmbxKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxKategori.Name = "cmbxKategori";
            this.cmbxKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbxKategori.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stok Kategori";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(117, 111);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 22);
            this.txtStok.TabIndex = 1;
            // 
            // lblStokFiyat
            // 
            this.lblStokFiyat.AutoSize = true;
            this.lblStokFiyat.Location = new System.Drawing.Point(5, 114);
            this.lblStokFiyat.Name = "lblStokFiyat";
            this.lblStokFiyat.Size = new System.Drawing.Size(73, 17);
            this.lblStokFiyat.TabIndex = 0;
            this.lblStokFiyat.Text = "Stok Fiyatı";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(117, 86);
            this.txtStokMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(121, 22);
            this.txtStokMiktari.TabIndex = 1;
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(5, 86);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(81, 17);
            this.lblStokMiktari.TabIndex = 0;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(117, 58);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(121, 22);
            this.txtStokAdi.TabIndex = 1;
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.AutoSize = true;
            this.lblStokAdi.Location = new System.Drawing.Point(5, 58);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(60, 17);
            this.lblStokAdi.TabIndex = 0;
            this.lblStokAdi.Text = "Stok Adı";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(117, 31);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(121, 22);
            this.txtStokKodu.TabIndex = 1;
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.Location = new System.Drawing.Point(5, 30);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(73, 17);
            this.lblStokKodu.TabIndex = 0;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 286);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::ServisOtomasyonu.Properties.Resources.kaydet;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(883, 36);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(208, 178);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(711, 36);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 5;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmYeniStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(1125, 517);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbStok);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmYeniStokEkle";
            this.Text = "Yeni Stok Ekle";
            this.gbStok.ResumeLayout(false);
            this.gbStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStok;
        private System.Windows.Forms.ComboBox cmbxKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblStokFiyat;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label lblStokAdi;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDon;
    }
}