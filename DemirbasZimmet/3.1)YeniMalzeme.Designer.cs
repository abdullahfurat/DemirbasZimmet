namespace DemirbasZimmet
{
    partial class YeniMalzeme
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mtxtMalzemeKodu = new System.Windows.Forms.MaskedTextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMalzemeTuru = new System.Windows.Forms.TextBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Malzeme Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(110, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 38);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "OLUŞTUR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mtxtMalzemeKodu
            // 
            this.mtxtMalzemeKodu.Location = new System.Drawing.Point(110, 21);
            this.mtxtMalzemeKodu.Mask = "0000000";
            this.mtxtMalzemeKodu.Name = "mtxtMalzemeKodu";
            this.mtxtMalzemeKodu.Size = new System.Drawing.Size(100, 20);
            this.mtxtMalzemeKodu.TabIndex = 5;
            this.mtxtMalzemeKodu.ValidatingType = typeof(int);
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(110, 59);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMalzemeAdi.TabIndex = 6;
            // 
            // txtMalzemeTuru
            // 
            this.txtMalzemeTuru.Location = new System.Drawing.Point(110, 92);
            this.txtMalzemeTuru.Name = "txtMalzemeTuru";
            this.txtMalzemeTuru.Size = new System.Drawing.Size(100, 20);
            this.txtMalzemeTuru.TabIndex = 7;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(110, 124);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(100, 20);
            this.nudAdet.TabIndex = 8;
            // 
            // YeniMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 247);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.txtMalzemeTuru);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.mtxtMalzemeKodu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Malzeme Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox mtxtMalzemeKodu;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMalzemeTuru;
        private System.Windows.Forms.NumericUpDown nudAdet;
    }
}