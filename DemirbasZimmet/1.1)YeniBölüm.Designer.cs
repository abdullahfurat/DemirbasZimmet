namespace DemirbasZimmet
{
    partial class YeniBölüm
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
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.txtBolumKodu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFaks = new System.Windows.Forms.MaskedTextBox();
            this.cmbAdresKodu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(130, 66);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(100, 20);
            this.txtBolumAdi.TabIndex = 16;
            // 
            // txtBolumKodu
            // 
            this.txtBolumKodu.Location = new System.Drawing.Point(130, 28);
            this.txtBolumKodu.Name = "txtBolumKodu";
            this.txtBolumKodu.Size = new System.Drawing.Size(100, 20);
            this.txtBolumKodu.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(130, 214);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 38);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "OLUŞTUR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Faks :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bölüm Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bölüm Kodu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adres Kodu :";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(130, 103);
            this.mtxtTelefon.Mask = "(9999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefon.TabIndex = 19;
            // 
            // mtxtFaks
            // 
            this.mtxtFaks.Location = new System.Drawing.Point(130, 138);
            this.mtxtFaks.Mask = "(9999) 000-0000";
            this.mtxtFaks.Name = "mtxtFaks";
            this.mtxtFaks.Size = new System.Drawing.Size(100, 20);
            this.mtxtFaks.TabIndex = 22;
            // 
            // cmbAdresKodu
            // 
            this.cmbAdresKodu.FormattingEnabled = true;
            this.cmbAdresKodu.Location = new System.Drawing.Point(130, 177);
            this.cmbAdresKodu.Name = "cmbAdresKodu";
            this.cmbAdresKodu.Size = new System.Drawing.Size(100, 21);
            this.cmbAdresKodu.TabIndex = 23;
            // 
            // YeniBölüm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 275);
            this.Controls.Add(this.cmbAdresKodu);
            this.Controls.Add(this.mtxtFaks);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.txtBolumKodu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniBölüm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Bölüm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.TextBox txtBolumKodu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.MaskedTextBox mtxtFaks;
        private System.Windows.Forms.ComboBox cmbAdresKodu;
    }
}