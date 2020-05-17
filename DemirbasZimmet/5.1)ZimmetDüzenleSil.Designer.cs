namespace DemirbasZimmet
{
    partial class ZimmetDüzenleSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtSicilNo = new System.Windows.Forms.MaskedTextBox();
            this.dtpBaslangıcTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tairihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlangıç Tarihi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtSicilNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Zimmet Sil";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(119, 102);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(153, 20);
            this.dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(119, 63);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(153, 20);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(98, 133);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(119, 28);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.ReadOnly = true;
            this.txtSicilNo.Size = new System.Drawing.Size(100, 20);
            this.txtSicilNo.TabIndex = 3;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(98, 132);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(84, 23);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtSicilNo);
            this.groupBox2.Controls.Add(this.dtpBaslangıcTarihi);
            this.groupBox2.Controls.Add(this.dtpBitisTarihi);
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 170);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zimmet Düzenle ";
            // 
            // mtxtSicilNo
            // 
            this.mtxtSicilNo.Location = new System.Drawing.Point(119, 28);
            this.mtxtSicilNo.Mask = "00000000";
            this.mtxtSicilNo.Name = "mtxtSicilNo";
            this.mtxtSicilNo.Size = new System.Drawing.Size(100, 20);
            this.mtxtSicilNo.TabIndex = 12;
            this.mtxtSicilNo.ValidatingType = typeof(int);
            // 
            // dtpBaslangıcTarihi
            // 
            this.dtpBaslangıcTarihi.Location = new System.Drawing.Point(119, 63);
            this.dtpBaslangıcTarihi.Name = "dtpBaslangıcTarihi";
            this.dtpBaslangıcTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpBaslangıcTarihi.TabIndex = 1;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(119, 102);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpBitisTarihi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sicil No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Başlangıç Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bitiş Tairihi :";
            // 
            // ZimmetDüzenleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZimmetDüzenleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zimmet Düzenle Sil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtSicilNo;
        private System.Windows.Forms.DateTimePicker dtpBaslangıcTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}