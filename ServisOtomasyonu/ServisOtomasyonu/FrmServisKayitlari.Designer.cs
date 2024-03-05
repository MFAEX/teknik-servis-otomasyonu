
namespace ServisOtomasyonu
{
    partial class FrmServisKayitlari
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
            this.dataKayit = new System.Windows.Forms.DataGridView();
            this.gbServisKayıt = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.cmbxPersonel = new System.Windows.Forms.ComboBox();
            this.cmbxBirim = new System.Windows.Forms.ComboBox();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.dategiris = new System.Windows.Forms.DateTimePicker();
            this.txtUzerindeGelenler = new System.Windows.Forms.TextBox();
            this.lblUzerinde = new System.Windows.Forms.Label();
            this.txtMusteriBeyan = new System.Windows.Forms.TextBox();
            this.lblMusteriBeyan = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.txtAriza = new System.Windows.Forms.TextBox();
            this.lblAriza = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtCihazTakip = new System.Windows.Forms.TextBox();
            this.lblTakipNo = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKayit)).BeginInit();
            this.gbServisKayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataKayit
            // 
            this.dataKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKayit.Location = new System.Drawing.Point(3, 450);
            this.dataKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataKayit.Name = "dataKayit";
            this.dataKayit.RowHeadersWidth = 51;
            this.dataKayit.RowTemplate.Height = 24;
            this.dataKayit.Size = new System.Drawing.Size(795, 295);
            this.dataKayit.TabIndex = 0;
            // 
            // gbServisKayıt
            // 
            this.gbServisKayıt.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbServisKayıt.Controls.Add(this.btnGeri);
            this.gbServisKayıt.Controls.Add(this.btnSil);
            this.gbServisKayıt.Controls.Add(this.btnDüzenle);
            this.gbServisKayıt.Controls.Add(this.cmbxPersonel);
            this.gbServisKayıt.Controls.Add(this.cmbxBirim);
            this.gbServisKayıt.Controls.Add(this.dateCikis);
            this.gbServisKayıt.Controls.Add(this.dategiris);
            this.gbServisKayıt.Controls.Add(this.txtUzerindeGelenler);
            this.gbServisKayıt.Controls.Add(this.lblUzerinde);
            this.gbServisKayıt.Controls.Add(this.txtMusteriBeyan);
            this.gbServisKayıt.Controls.Add(this.lblMusteriBeyan);
            this.gbServisKayıt.Controls.Add(this.txtDurum);
            this.gbServisKayıt.Controls.Add(this.lblPersonel);
            this.gbServisKayıt.Controls.Add(this.lblDurum);
            this.gbServisKayıt.Controls.Add(this.lblBirim);
            this.gbServisKayıt.Controls.Add(this.textBox4);
            this.gbServisKayıt.Controls.Add(this.lblSeriNo);
            this.gbServisKayıt.Controls.Add(this.txtAriza);
            this.gbServisKayıt.Controls.Add(this.lblAriza);
            this.gbServisKayıt.Controls.Add(this.txtMarka);
            this.gbServisKayıt.Controls.Add(this.lblMarka);
            this.gbServisKayıt.Controls.Add(this.txtCihazTakip);
            this.gbServisKayıt.Controls.Add(this.lblTakipNo);
            this.gbServisKayıt.Controls.Add(this.lblGiris);
            this.gbServisKayıt.Controls.Add(this.lblCikis);
            this.gbServisKayıt.Location = new System.Drawing.Point(12, 12);
            this.gbServisKayıt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServisKayıt.Name = "gbServisKayıt";
            this.gbServisKayıt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServisKayıt.Size = new System.Drawing.Size(785, 432);
            this.gbServisKayıt.TabIndex = 1;
            this.gbServisKayıt.TabStop = false;
            this.gbServisKayıt.Text = "Servis Kayıtları";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(558, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 66);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(382, 270);
            this.btnDüzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(139, 66);
            this.btnDüzenle.TabIndex = 27;
            this.btnDüzenle.Text = "Kayıt Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            // 
            // cmbxPersonel
            // 
            this.cmbxPersonel.FormattingEnabled = true;
            this.cmbxPersonel.Location = new System.Drawing.Point(121, 171);
            this.cmbxPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxPersonel.Name = "cmbxPersonel";
            this.cmbxPersonel.Size = new System.Drawing.Size(133, 24);
            this.cmbxPersonel.TabIndex = 26;
            // 
            // cmbxBirim
            // 
            this.cmbxBirim.FormattingEnabled = true;
            this.cmbxBirim.Location = new System.Drawing.Point(121, 142);
            this.cmbxBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxBirim.Name = "cmbxBirim";
            this.cmbxBirim.Size = new System.Drawing.Size(133, 24);
            this.cmbxBirim.TabIndex = 25;
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(495, 81);
            this.dateCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(200, 22);
            this.dateCikis.TabIndex = 24;
            // 
            // dategiris
            // 
            this.dategiris.Location = new System.Drawing.Point(495, 31);
            this.dategiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dategiris.Name = "dategiris";
            this.dategiris.Size = new System.Drawing.Size(200, 22);
            this.dategiris.TabIndex = 23;
            // 
            // txtUzerindeGelenler
            // 
            this.txtUzerindeGelenler.Location = new System.Drawing.Point(495, 135);
            this.txtUzerindeGelenler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUzerindeGelenler.Multiline = true;
            this.txtUzerindeGelenler.Name = "txtUzerindeGelenler";
            this.txtUzerindeGelenler.Size = new System.Drawing.Size(185, 94);
            this.txtUzerindeGelenler.TabIndex = 18;
            // 
            // lblUzerinde
            // 
            this.lblUzerinde.AutoSize = true;
            this.lblUzerinde.Location = new System.Drawing.Point(365, 135);
            this.lblUzerinde.Name = "lblUzerinde";
            this.lblUzerinde.Size = new System.Drawing.Size(123, 17);
            this.lblUzerinde.TabIndex = 14;
            this.lblUzerinde.Text = "Üzerinde Gelenler";
            // 
            // txtMusteriBeyan
            // 
            this.txtMusteriBeyan.Location = new System.Drawing.Point(121, 241);
            this.txtMusteriBeyan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriBeyan.Multiline = true;
            this.txtMusteriBeyan.Name = "txtMusteriBeyan";
            this.txtMusteriBeyan.Size = new System.Drawing.Size(133, 118);
            this.txtMusteriBeyan.TabIndex = 17;
            // 
            // lblMusteriBeyan
            // 
            this.lblMusteriBeyan.AutoSize = true;
            this.lblMusteriBeyan.Location = new System.Drawing.Point(11, 244);
            this.lblMusteriBeyan.Name = "lblMusteriBeyan";
            this.lblMusteriBeyan.Size = new System.Drawing.Size(101, 17);
            this.lblMusteriBeyan.TabIndex = 15;
            this.lblMusteriBeyan.Text = "Müşteri Beyanı";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(121, 206);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(133, 22);
            this.txtDurum.TabIndex = 16;
            this.txtDurum.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(11, 176);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(64, 17);
            this.lblPersonel.TabIndex = 12;
            this.lblPersonel.Text = "Personel";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(11, 210);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 17);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(11, 146);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(39, 17);
            this.lblBirim.TabIndex = 10;
            this.lblBirim.Text = "Birim";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 114);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 22);
            this.textBox4.TabIndex = 19;
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.Location = new System.Drawing.Point(11, 118);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(94, 17);
            this.lblSeriNo.TabIndex = 9;
            this.lblSeriNo.Text = "Cihaz Seri No";
            // 
            // txtAriza
            // 
            this.txtAriza.Location = new System.Drawing.Point(121, 87);
            this.txtAriza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAriza.Name = "txtAriza";
            this.txtAriza.Size = new System.Drawing.Size(133, 22);
            this.txtAriza.TabIndex = 20;
            // 
            // lblAriza
            // 
            this.lblAriza.AutoSize = true;
            this.lblAriza.Location = new System.Drawing.Point(11, 92);
            this.lblAriza.Name = "lblAriza";
            this.lblAriza.Size = new System.Drawing.Size(50, 17);
            this.lblAriza.TabIndex = 8;
            this.lblAriza.Text = "Arızası";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(121, 59);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(133, 22);
            this.txtMarka.TabIndex = 21;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(11, 62);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(96, 17);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Cihaz Markası";
            // 
            // txtCihazTakip
            // 
            this.txtCihazTakip.Location = new System.Drawing.Point(121, 31);
            this.txtCihazTakip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCihazTakip.Name = "txtCihazTakip";
            this.txtCihazTakip.Size = new System.Drawing.Size(133, 22);
            this.txtCihazTakip.TabIndex = 22;
            // 
            // lblTakipNo
            // 
            this.lblTakipNo.AutoSize = true;
            this.lblTakipNo.Location = new System.Drawing.Point(11, 34);
            this.lblTakipNo.Name = "lblTakipNo";
            this.lblTakipNo.Size = new System.Drawing.Size(104, 17);
            this.lblTakipNo.TabIndex = 6;
            this.lblTakipNo.Text = "Cihaz Takip No";
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(365, 36);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(77, 17);
            this.lblGiris.TabIndex = 11;
            this.lblGiris.Text = "Giriş Tarihi";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(365, 81);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(77, 17);
            this.lblCikis.TabIndex = 13;
            this.lblCikis.Text = "Çıkış Tarihi";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(579, 353);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(116, 79);
            this.btnGeri.TabIndex = 29;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmServisKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(800, 758);
            this.Controls.Add(this.gbServisKayıt);
            this.Controls.Add(this.dataKayit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmServisKayitlari";
            this.Text = "Servis Kayıtları";
            this.Load += new System.EventHandler(this.FrmServisKayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKayit)).EndInit();
            this.gbServisKayıt.ResumeLayout(false);
            this.gbServisKayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKayit;
        private System.Windows.Forms.GroupBox gbServisKayıt;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.ComboBox cmbxPersonel;
        private System.Windows.Forms.ComboBox cmbxBirim;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.DateTimePicker dategiris;
        private System.Windows.Forms.TextBox txtUzerindeGelenler;
        private System.Windows.Forms.Label lblUzerinde;
        private System.Windows.Forms.TextBox txtMusteriBeyan;
        private System.Windows.Forms.Label lblMusteriBeyan;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.TextBox txtAriza;
        private System.Windows.Forms.Label lblAriza;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtCihazTakip;
        private System.Windows.Forms.Label lblTakipNo;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
    }
}