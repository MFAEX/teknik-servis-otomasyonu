
namespace ServisOtomasyonu
{
    partial class FrmPersonelBilgi
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
            this.dataPersonel = new System.Windows.Forms.DataGridView();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).BeginInit();
            this.gbAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPersonel
            // 
            this.dataPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonel.Location = new System.Drawing.Point(12, 158);
            this.dataPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPersonel.Name = "dataPersonel";
            this.dataPersonel.RowHeadersWidth = 51;
            this.dataPersonel.RowTemplate.Height = 24;
            this.dataPersonel.Size = new System.Drawing.Size(776, 281);
            this.dataPersonel.TabIndex = 0;
            // 
            // gbAra
            // 
            this.gbAra.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbAra.Controls.Add(this.txtSoyad);
            this.gbAra.Controls.Add(this.txtAd);
            this.gbAra.Controls.Add(this.txtPersonelNo);
            this.gbAra.Controls.Add(this.lblSoyad);
            this.gbAra.Controls.Add(this.lblAd);
            this.gbAra.Controls.Add(this.lblPersonelNo);
            this.gbAra.Location = new System.Drawing.Point(12, 12);
            this.gbAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Name = "gbAra";
            this.gbAra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Size = new System.Drawing.Size(300, 140);
            this.gbAra.TabIndex = 1;
            this.gbAra.TabStop = false;
            this.gbAra.Text = "Ara";
            this.gbAra.UseCompatibleTextRendering = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 86);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(135, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 60);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(99, 32);
            this.txtPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(135, 22);
            this.txtPersonelNo.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(5, 91);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 17);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(5, 60);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 17);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(5, 30);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(86, 17);
            this.lblPersonelNo.TabIndex = 0;
            this.lblPersonelNo.Text = "Personel No";
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(672, 44);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 4;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmPersonelBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.dataPersonel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPersonelBilgi";
            this.Text = "Personel Bilgisi";
            this.Load += new System.EventHandler(this.FrmPersonelBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).EndInit();
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPersonel;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Button btnDon;
    }
}