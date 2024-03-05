
namespace ServisOtomasyonu
{
    partial class FrmStok
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
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.dataStok = new System.Windows.Forms.DataGridView();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.gbAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAra
            // 
            this.gbAra.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.gbAra.Controls.Add(this.comboBox1);
            this.gbAra.Controls.Add(this.label2);
            this.gbAra.Controls.Add(this.textBox2);
            this.gbAra.Controls.Add(this.lblStokAdi);
            this.gbAra.Controls.Add(this.textBox1);
            this.gbAra.Controls.Add(this.lblStokKodu);
            this.gbAra.Location = new System.Drawing.Point(0, 0);
            this.gbAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Name = "gbAra";
            this.gbAra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAra.Size = new System.Drawing.Size(379, 197);
            this.gbAra.TabIndex = 0;
            this.gbAra.TabStop = false;
            this.gbAra.Text = "Ara";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 87);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 1;
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.AutoSize = true;
            this.lblStokAdi.Location = new System.Drawing.Point(12, 59);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(60, 17);
            this.lblStokAdi.TabIndex = 0;
            this.lblStokAdi.Text = "Stok Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.Location = new System.Drawing.Point(12, 31);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(73, 17);
            this.lblStokKodu.TabIndex = 0;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // dataStok
            // 
            this.dataStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStok.Location = new System.Drawing.Point(0, 203);
            this.dataStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataStok.Name = "dataStok";
            this.dataStok.RowHeadersWidth = 51;
            this.dataStok.RowTemplate.Height = 24;
            this.dataStok.Size = new System.Drawing.Size(1045, 302);
            this.dataStok.TabIndex = 0;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(779, 25);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(116, 79);
            this.btnDon.TabIndex = 4;
            this.btnDon.Text = "Ana Ekrana Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(641, 25);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(116, 79);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServisOtomasyonu.Properties.Resources.form_arkaplan;
            this.ClientSize = new System.Drawing.Size(1047, 506);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.dataStok);
            this.Controls.Add(this.gbAra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStok";
            this.Text = "Stok Kayıtları";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblStokAdi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.DataGridView dataStok;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnGeri;
    }
}