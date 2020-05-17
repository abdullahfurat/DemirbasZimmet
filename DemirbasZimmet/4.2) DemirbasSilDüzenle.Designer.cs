namespace DemirbasZimmet
{
    partial class DemirbasSilDüzenle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbBolumKod = new System.Windows.Forms.ComboBox();
            this.cmbMalzKod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtKod = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.cmbBolumDuzenle = new System.Windows.Forms.ComboBox();
            this.cmbMalzDuzenle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtDemirbasKodDuzenle = new System.Windows.Forms.MaskedTextBox();
            this.txtDemirbasAdDuzenle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.cmbBolumKod);
            this.groupBox1.Controls.Add(this.cmbMalzKod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtKod);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 221);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Demirbaş ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(121, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 29);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbBolumKod
            // 
            this.cmbBolumKod.FormattingEnabled = true;
            this.cmbBolumKod.Location = new System.Drawing.Point(121, 135);
            this.cmbBolumKod.Name = "cmbBolumKod";
            this.cmbBolumKod.Size = new System.Drawing.Size(100, 21);
            this.cmbBolumKod.TabIndex = 10;
            // 
            // cmbMalzKod
            // 
            this.cmbMalzKod.FormattingEnabled = true;
            this.cmbMalzKod.Location = new System.Drawing.Point(121, 102);
            this.cmbMalzKod.Name = "cmbMalzKod";
            this.cmbMalzKod.Size = new System.Drawing.Size(100, 21);
            this.cmbMalzKod.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Malzeme Kodu:";
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
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 14;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.cmbBolumDuzenle);
            this.groupBox2.Controls.Add(this.cmbMalzDuzenle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mtxtDemirbasKodDuzenle);
            this.groupBox2.Controls.Add(this.txtDemirbasAdDuzenle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(290, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 221);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demirbaş Düzenle";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(121, 173);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 29);
            this.btnDuzenle.TabIndex = 19;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // cmbBolumDuzenle
            // 
            this.cmbBolumDuzenle.FormattingEnabled = true;
            this.cmbBolumDuzenle.Location = new System.Drawing.Point(121, 135);
            this.cmbBolumDuzenle.Name = "cmbBolumDuzenle";
            this.cmbBolumDuzenle.Size = new System.Drawing.Size(100, 21);
            this.cmbBolumDuzenle.TabIndex = 10;
            // 
            // cmbMalzDuzenle
            // 
            this.cmbMalzDuzenle.FormattingEnabled = true;
            this.cmbMalzDuzenle.Location = new System.Drawing.Point(121, 102);
            this.cmbMalzDuzenle.Name = "cmbMalzDuzenle";
            this.cmbMalzDuzenle.Size = new System.Drawing.Size(100, 21);
            this.cmbMalzDuzenle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bölüm Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Malzeme Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Demirbaş Kodu :";
            // 
            // mtxtDemirbasKodDuzenle
            // 
            this.mtxtDemirbasKodDuzenle.Location = new System.Drawing.Point(121, 30);
            this.mtxtDemirbasKodDuzenle.Mask = "0000000";
            this.mtxtDemirbasKodDuzenle.Name = "mtxtDemirbasKodDuzenle";
            this.mtxtDemirbasKodDuzenle.Size = new System.Drawing.Size(100, 20);
            this.mtxtDemirbasKodDuzenle.TabIndex = 16;
            this.mtxtDemirbasKodDuzenle.ValidatingType = typeof(int);
            // 
            // txtDemirbasAdDuzenle
            // 
            this.txtDemirbasAdDuzenle.Location = new System.Drawing.Point(121, 63);
            this.txtDemirbasAdDuzenle.Name = "txtDemirbasAdDuzenle";
            this.txtDemirbasAdDuzenle.Size = new System.Drawing.Size(100, 20);
            this.txtDemirbasAdDuzenle.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Demirbaş Adı :";
            // 
            // DemirbasSilDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DemirbasSilDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemirbasSilDüzenle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbBolumKod;
        private System.Windows.Forms.ComboBox cmbMalzKod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtKod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ComboBox cmbBolumDuzenle;
        private System.Windows.Forms.ComboBox cmbMalzDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtDemirbasKodDuzenle;
        private System.Windows.Forms.TextBox txtDemirbasAdDuzenle;
        private System.Windows.Forms.Label label7;
    }
}