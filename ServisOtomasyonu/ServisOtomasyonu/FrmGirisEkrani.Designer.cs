
namespace ServisOtomasyonu
{
    partial class FrmGirisEkrani
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
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lblMagaza = new System.Windows.Forms.Label();
            this.cmbxMagaza = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(61, 207);
            this.txtPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(192, 22);
            this.txtPersonelNo.TabIndex = 0;
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.BackColor = System.Drawing.Color.Navy;
            this.lblPersonelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonelNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonelNo.Location = new System.Drawing.Point(64, 162);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(169, 20);
            this.lblPersonelNo.TabIndex = 1;
            this.lblPersonelNo.Text = "Personel Numarası";
            // 
            // lblMagaza
            // 
            this.lblMagaza.AutoSize = true;
            this.lblMagaza.BackColor = System.Drawing.Color.Navy;
            this.lblMagaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMagaza.Location = new System.Drawing.Point(116, 57);
            this.lblMagaza.Name = "lblMagaza";
            this.lblMagaza.Size = new System.Drawing.Size(82, 24);
            this.lblMagaza.TabIndex = 2;
            this.lblMagaza.Text = "Mağaza";
            // 
            // cmbxMagaza
            // 
            this.cmbxMagaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMagaza.FormattingEnabled = true;
            this.cmbxMagaza.Location = new System.Drawing.Point(61, 98);
            this.cmbxMagaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxMagaza.Name = "cmbxMagaza";
            this.cmbxMagaza.Size = new System.Drawing.Size(192, 24);
            this.cmbxMagaza.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(61, 311);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(192, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Navy;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSifre.Location = new System.Drawing.Point(125, 274);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 24);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Navy;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGiris.Image = global::ServisOtomasyonu.Properties.Resources.giris;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(61, 372);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(193, 74);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // FrmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(328, 482);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.cmbxMagaza);
            this.Controls.Add(this.lblMagaza);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.txtPersonelNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGirisEkrani";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Label lblMagaza;
        private System.Windows.Forms.ComboBox cmbxMagaza;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}