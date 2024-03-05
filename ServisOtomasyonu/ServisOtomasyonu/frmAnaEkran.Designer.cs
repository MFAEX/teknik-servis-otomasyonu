
namespace ServisOtomasyonu
{
    partial class frmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMusteriBilgileri = new System.Windows.Forms.Button();
            this.btnStokKaydi = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnServisKayitlari = new System.Windows.Forms.Button();
            this.btnPersonelBilgisi = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnServisIslemEkle = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Image = global::ServisOtomasyonu.Properties.Resources.musteriEkle;
            this.btnYeniKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniKayit.Location = new System.Drawing.Point(33, 90);
            this.btnYeniKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(209, 91);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt Ekle";
            this.btnYeniKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 657);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMusteriBilgileri
            // 
            this.btnMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBilgileri.Image = global::ServisOtomasyonu.Properties.Resources.musteriBilgisi;
            this.btnMusteriBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriBilgileri.Location = new System.Drawing.Point(273, 90);
            this.btnMusteriBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriBilgileri.Name = "btnMusteriBilgileri";
            this.btnMusteriBilgileri.Size = new System.Drawing.Size(209, 91);
            this.btnMusteriBilgileri.TabIndex = 1;
            this.btnMusteriBilgileri.Text = "Müşteri Bilgileri";
            this.btnMusteriBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriBilgileri.UseVisualStyleBackColor = true;
            this.btnMusteriBilgileri.Click += new System.EventHandler(this.btnMusteriBilgileri_Click);
            // 
            // btnStokKaydi
            // 
            this.btnStokKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokKaydi.Image = global::ServisOtomasyonu.Properties.Resources.stokKayitlari1;
            this.btnStokKaydi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokKaydi.Location = new System.Drawing.Point(33, 201);
            this.btnStokKaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokKaydi.Name = "btnStokKaydi";
            this.btnStokKaydi.Size = new System.Drawing.Size(209, 92);
            this.btnStokKaydi.TabIndex = 2;
            this.btnStokKaydi.Text = "Stok Kayıtları";
            this.btnStokKaydi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStokKaydi.UseVisualStyleBackColor = true;
            this.btnStokKaydi.Click += new System.EventHandler(this.btnStokKaydi_Click);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.Image = global::ServisOtomasyonu.Properties.Resources.yeniStokEkle;
            this.btnStokEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokEkle.Location = new System.Drawing.Point(519, 201);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(219, 92);
            this.btnStokEkle.TabIndex = 3;
            this.btnStokEkle.Text = "Yeni Stok Ekle";
            this.btnStokEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnServisKayitlari
            // 
            this.btnServisKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServisKayitlari.Image = global::ServisOtomasyonu.Properties.Resources.servisKayit;
            this.btnServisKayitlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServisKayitlari.Location = new System.Drawing.Point(519, 96);
            this.btnServisKayitlari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServisKayitlari.Name = "btnServisKayitlari";
            this.btnServisKayitlari.Size = new System.Drawing.Size(219, 85);
            this.btnServisKayitlari.TabIndex = 5;
            this.btnServisKayitlari.Text = "Servis Kayıtları";
            this.btnServisKayitlari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServisKayitlari.UseVisualStyleBackColor = true;
            this.btnServisKayitlari.Click += new System.EventHandler(this.btnServisKayitlari_Click);
            // 
            // btnPersonelBilgisi
            // 
            this.btnPersonelBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelBilgisi.Image = global::ServisOtomasyonu.Properties.Resources.personelBilgi;
            this.btnPersonelBilgisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelBilgisi.Location = new System.Drawing.Point(273, 201);
            this.btnPersonelBilgisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelBilgisi.Name = "btnPersonelBilgisi";
            this.btnPersonelBilgisi.Size = new System.Drawing.Size(209, 92);
            this.btnPersonelBilgisi.TabIndex = 5;
            this.btnPersonelBilgisi.Text = "Personel Bilgisi";
            this.btnPersonelBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelBilgisi.UseVisualStyleBackColor = true;
            this.btnPersonelBilgisi.Click += new System.EventHandler(this.btnPersonelBilgisi_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminPanel.Image = global::ServisOtomasyonu.Properties.Resources.admin;
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.Location = new System.Drawing.Point(780, 322);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(220, 80);
            this.btnAdminPanel.TabIndex = 3;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnServisIslemEkle
            // 
            this.btnServisIslemEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnServisIslemEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServisIslemEkle.Image = global::ServisOtomasyonu.Properties.Resources.yeniServisEkle;
            this.btnServisIslemEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServisIslemEkle.Location = new System.Drawing.Point(780, 96);
            this.btnServisIslemEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServisIslemEkle.Name = "btnServisIslemEkle";
            this.btnServisIslemEkle.Size = new System.Drawing.Size(220, 85);
            this.btnServisIslemEkle.TabIndex = 6;
            this.btnServisIslemEkle.Text = "Servis İşlem Ekle";
            this.btnServisIslemEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServisIslemEkle.UseVisualStyleBackColor = false;
            this.btnServisIslemEkle.Click += new System.EventHandler(this.btnServisIslemEkle_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.Image = global::ServisOtomasyonu.Properties.Resources.fatura;
            this.btnFaturalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturalar.Location = new System.Drawing.Point(780, 208);
            this.btnFaturalar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(220, 79);
            this.btnFaturalar.TabIndex = 7;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturalar.UseVisualStyleBackColor = false;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(1025, 500);
            this.Controls.Add(this.btnFaturalar);
            this.Controls.Add(this.btnServisIslemEkle);
            this.Controls.Add(this.btnPersonelBilgisi);
            this.Controls.Add(this.btnServisKayitlari);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnStokKaydi);
            this.Controls.Add(this.btnMusteriBilgileri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnYeniKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMusteriBilgileri;
        private System.Windows.Forms.Button btnStokKaydi;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnServisKayitlari;
        private System.Windows.Forms.Button btnPersonelBilgisi;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnServisIslemEkle;
        private System.Windows.Forms.Button btnFaturalar;
    }
}

