
namespace ServisOtomasyonu
{
    partial class FrmAdminPanel
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
            this.gbPersonel = new System.Windows.Forms.GroupBox();
            this.cmbxMagaza = new System.Windows.Forms.ComboBox();
            this.cmbxBirim = new System.Windows.Forms.ComboBox();
            this.cmbxYetki = new System.Windows.Forms.ComboBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblMagaza = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblPersonelSoyadi = new System.Windows.Forms.Label();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.dataPersonel = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.gbPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonel
            // 
            this.gbPersonel.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbPersonel.Controls.Add(this.cmbxMagaza);
            this.gbPersonel.Controls.Add(this.cmbxBirim);
            this.gbPersonel.Controls.Add(this.cmbxYetki);
            this.gbPersonel.Controls.Add(this.txtPersonelSoyadi);
            this.gbPersonel.Controls.Add(this.txtPersonelAdi);
            this.gbPersonel.Controls.Add(this.txtPersonelNo);
            this.gbPersonel.Controls.Add(this.lblYetki);
            this.gbPersonel.Controls.Add(this.lblMagaza);
            this.gbPersonel.Controls.Add(this.lblBirim);
            this.gbPersonel.Controls.Add(this.lblPersonelSoyadi);
            this.gbPersonel.Controls.Add(this.lblPersonelAdi);
            this.gbPersonel.Controls.Add(this.lblPersonelNo);
            this.gbPersonel.Location = new System.Drawing.Point(0, 0);
            this.gbPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPersonel.Name = "gbPersonel";
            this.gbPersonel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPersonel.Size = new System.Drawing.Size(352, 258);
            this.gbPersonel.TabIndex = 0;
            this.gbPersonel.TabStop = false;
            this.gbPersonel.Text = "Personel Ekle-Çıkar";
            // 
            // cmbxMagaza
            // 
            this.cmbxMagaza.FormattingEnabled = true;
            this.cmbxMagaza.Location = new System.Drawing.Point(81, 164);
            this.cmbxMagaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxMagaza.Name = "cmbxMagaza";
            this.cmbxMagaza.Size = new System.Drawing.Size(161, 24);
            this.cmbxMagaza.TabIndex = 3;
            // 
            // cmbxBirim
            // 
            this.cmbxBirim.FormattingEnabled = true;
            this.cmbxBirim.Location = new System.Drawing.Point(81, 134);
            this.cmbxBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxBirim.Name = "cmbxBirim";
            this.cmbxBirim.Size = new System.Drawing.Size(161, 24);
            this.cmbxBirim.TabIndex = 3;
            // 
            // cmbxYetki
            // 
            this.cmbxYetki.FormattingEnabled = true;
            this.cmbxYetki.Location = new System.Drawing.Point(81, 194);
            this.cmbxYetki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxYetki.Name = "cmbxYetki";
            this.cmbxYetki.Size = new System.Drawing.Size(161, 24);
            this.cmbxYetki.TabIndex = 2;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(129, 101);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(139, 22);
            this.txtPersonelSoyadi.TabIndex = 1;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(104, 69);
            this.txtPersonelAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(139, 22);
            this.txtPersonelAdi.TabIndex = 1;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(104, 41);
            this.txtPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(139, 22);
            this.txtPersonelNo.TabIndex = 1;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(12, 197);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(39, 17);
            this.lblYetki.TabIndex = 0;
            this.lblYetki.Text = "Yetki";
            // 
            // lblMagaza
            // 
            this.lblMagaza.AutoSize = true;
            this.lblMagaza.Location = new System.Drawing.Point(12, 171);
            this.lblMagaza.Name = "lblMagaza";
            this.lblMagaza.Size = new System.Drawing.Size(58, 17);
            this.lblMagaza.TabIndex = 0;
            this.lblMagaza.Text = "Mağaza";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(12, 138);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(39, 17);
            this.lblBirim.TabIndex = 0;
            this.lblBirim.Text = "Birim";
            // 
            // lblPersonelSoyadi
            // 
            this.lblPersonelSoyadi.AutoSize = true;
            this.lblPersonelSoyadi.Location = new System.Drawing.Point(12, 106);
            this.lblPersonelSoyadi.Name = "lblPersonelSoyadi";
            this.lblPersonelSoyadi.Size = new System.Drawing.Size(111, 17);
            this.lblPersonelSoyadi.TabIndex = 0;
            this.lblPersonelSoyadi.Text = "Personel Soyadı";
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.Location = new System.Drawing.Point(12, 75);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(88, 17);
            this.lblPersonelAdi.TabIndex = 0;
            this.lblPersonelAdi.Text = "Personel Adı";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(12, 46);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(86, 17);
            this.lblPersonelNo.TabIndex = 0;
            this.lblPersonelNo.Text = "Personel No";
            // 
            // dataPersonel
            // 
            this.dataPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonel.Location = new System.Drawing.Point(0, 263);
            this.dataPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPersonel.Name = "dataPersonel";
            this.dataPersonel.RowHeadersWidth = 51;
            this.dataPersonel.RowTemplate.Height = 24;
            this.dataPersonel.Size = new System.Drawing.Size(796, 325);
            this.dataPersonel.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::ServisOtomasyonu.Properties.Resources.kaydet;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(383, 118);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 123);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::ServisOtomasyonu.Properties.Resources.sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(579, 118);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 123);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(672, 12);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 3;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataPersonel);
            this.Controls.Add(this.gbPersonel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.gbPersonel.ResumeLayout(false);
            this.gbPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonel;
        private System.Windows.Forms.DataGridView dataPersonel;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.ComboBox cmbxMagaza;
        private System.Windows.Forms.ComboBox cmbxBirim;
        private System.Windows.Forms.ComboBox cmbxYetki;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblMagaza;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblPersonelSoyadi;
        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDon;
    }
}