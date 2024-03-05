
namespace ServisOtomasyonu
{
    partial class FrmServisIslem
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
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnKayitSec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltoplamfiyat = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnStokSec = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(51, 34);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(115, 79);
            this.btnMusteriSec.TabIndex = 0;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnKayitSec
            // 
            this.btnKayitSec.Location = new System.Drawing.Point(51, 151);
            this.btnKayitSec.Name = "btnKayitSec";
            this.btnKayitSec.Size = new System.Drawing.Size(115, 79);
            this.btnKayitSec.TabIndex = 0;
            this.btnKayitSec.Text = "Servis Seç";
            this.btnKayitSec.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 236);
            this.textBox1.TabIndex = 1;
            // 
            // lbltoplamfiyat
            // 
            this.lbltoplamfiyat.AutoSize = true;
            this.lbltoplamfiyat.Location = new System.Drawing.Point(509, 258);
            this.lbltoplamfiyat.Name = "lbltoplamfiyat";
            this.lbltoplamfiyat.Size = new System.Drawing.Size(89, 17);
            this.lbltoplamfiyat.TabIndex = 2;
            this.lbltoplamfiyat.Text = "Toplam Fiyat";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(557, 280);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(25, 17);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "TL";
            this.lblFiyat.Click += new System.EventHandler(this.lblFiyat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(680, 337);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 85);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnStokSec
            // 
            this.btnStokSec.Location = new System.Drawing.Point(51, 258);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(115, 60);
            this.btnStokSec.TabIndex = 4;
            this.btnStokSec.Text = "Stok Seç";
            this.btnStokSec.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(51, 343);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 5;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmServisIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnStokSec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lbltoplamfiyat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKayitSec);
            this.Controls.Add(this.btnMusteriSec);
            this.Name = "FrmServisIslem";
            this.Text = "FrmServisIslem";
            this.Load += new System.EventHandler(this.FrmServisIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnKayitSec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltoplamfiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnStokSec;
        private System.Windows.Forms.Button btnDon;
    }
}