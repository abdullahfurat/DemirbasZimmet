namespace DemirbasZimmet
{
    partial class YeniDemirbas
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
            this.cmbBolumKod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtKod = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMalzKod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBolumKod
            // 
            this.cmbBolumKod.FormattingEnabled = true;
            this.cmbBolumKod.Location = new System.Drawing.Point(121, 135);
            this.cmbBolumKod.Name = "cmbBolumKod";
            this.cmbBolumKod.Size = new System.Drawing.Size(100, 21);
            this.cmbBolumKod.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bölüm Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Demirbaş Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Demirbaş Kodu :";
            // 
            // mtxtKod
            // 
            this.mtxtKod.Location = new System.Drawing.Point(121, 30);
            this.mtxtKod.Mask = "0000000";
            this.mtxtKod.Name = "mtxtKod";
            this.mtxtKod.Size = new System.Drawing.Size(100, 20);
            this.mtxtKod.TabIndex = 16;
            this.mtxtKod.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Malzeme Kodu:";
            // 
            // cmbMalzKod
            // 
            this.cmbMalzKod.FormattingEnabled = true;
            this.cmbMalzKod.Location = new System.Drawing.Point(121, 102);
            this.cmbMalzKod.Name = "cmbMalzKod";
            this.cmbMalzKod.Size = new System.Drawing.Size(100, 21);
            this.cmbMalzKod.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.cmbBolumKod);
            this.groupBox1.Controls.Add(this.cmbMalzKod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtKod);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 221);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demirbaş Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(121, 173);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(100, 29);
            this.btnOlustur.TabIndex = 19;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // YeniDemirbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "YeniDemirbas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniDemirbas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBolumKod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMalzKod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOlustur;
    }
}