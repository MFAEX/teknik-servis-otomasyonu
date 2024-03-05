
namespace ServisOtomasyonu
{
    partial class frmMusterisec
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
            this.dataMusteri = new System.Windows.Forms.DataGridView();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.lblCariNo = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusteri)).BeginInit();
            this.gbAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMusteri
            // 
            this.dataMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusteri.Location = new System.Drawing.Point(12, 175);
            this.dataMusteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataMusteri.Name = "dataMusteri";
            this.dataMusteri.RowHeadersWidth = 51;
            this.dataMusteri.RowTemplate.Height = 24;
            this.dataMusteri.Size = new System.Drawing.Size(787, 263);
            this.dataMusteri.TabIndex = 0;
            // 
            // gbAra
            // 
            this.gbAra.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbAra.Controls.Add(this.txtSoyad);
            this.gbAra.Controls.Add(this.txtAd);
            this.gbAra.Controls.Add(this.lblSoyad);
            this.gbAra.Controls.Add(this.lblAd);
            this.gbAra.Controls.Add(this.txtCariNo);
            this.gbAra.Controls.Add(this.lblCariNo);
            this.gbAra.Location = new System.Drawing.Point(12, 12);
            this.gbAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Name = "gbAra";
            this.gbAra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Size = new System.Drawing.Size(251, 158);
            this.gbAra.TabIndex = 1;
            this.gbAra.TabStop = false;
            this.gbAra.Text = "Ara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(67, 87);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(67, 55);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(5, 87);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 17);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(5, 58);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(67, 27);
            this.txtCariNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Size = new System.Drawing.Size(132, 22);
            this.txtCariNo.TabIndex = 1;
            // 
            // lblCariNo
            // 
            this.lblCariNo.AutoSize = true;
            this.lblCariNo.Location = new System.Drawing.Point(5, 30);
            this.lblCariNo.Name = "lblCariNo";
            this.lblCariNo.Size = new System.Drawing.Size(55, 17);
            this.lblCariNo.TabIndex = 0;
            this.lblCariNo.Text = "Cari No";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Image = global::ServisOtomasyonu.Properties.Resources.musteriSec;
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.Location = new System.Drawing.Point(607, 39);
            this.btnMusteriSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(181, 129);
            this.btnMusteriSec.TabIndex = 2;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(468, 39);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 4;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(346, 37);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(116, 79);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmMusterisec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.dataMusteri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMusterisec";
            this.Text = "frmMusterisec";
            this.Load += new System.EventHandler(this.frmMusterisec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMusteri)).EndInit();
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMusteri;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.Label lblCariNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnGeri;
    }
}