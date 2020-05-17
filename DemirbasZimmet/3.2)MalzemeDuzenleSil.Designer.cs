namespace DemirbasZimmet
{
    partial class MalzemeDuzenleSil
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
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.txtMalzemeTuru = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.mtxtMalzemeKodu = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAdetDuzenle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTurDuzenle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdDuzenle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtKodDuzenle = new System.Windows.Forms.MaskedTextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdetDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(120, 134);
            this.nudAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(100, 20);
            this.nudAdet.TabIndex = 17;
            // 
            // txtMalzemeTuru
            // 
            this.txtMalzemeTuru.Location = new System.Drawing.Point(120, 102);
            this.txtMalzemeTuru.Name = "txtMalzemeTuru";
            this.txtMalzemeTuru.Size = new System.Drawing.Size(100, 20);
            this.txtMalzemeTuru.TabIndex = 16;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(120, 69);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMalzemeAdi.TabIndex = 15;
            // 
            // mtxtMalzemeKodu
            // 
            this.mtxtMalzemeKodu.Location = new System.Drawing.Point(120, 31);
            this.mtxtMalzemeKodu.Mask = "0000000";
            this.mtxtMalzemeKodu.Name = "mtxtMalzemeKodu";
            this.mtxtMalzemeKodu.Size = new System.Drawing.Size(100, 20);
            this.mtxtMalzemeKodu.TabIndex = 14;
            this.mtxtMalzemeKodu.ValidatingType = typeof(int);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(74, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 38);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Malzeme Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Malzeme Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Malzeme Kodu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMalzemeTuru);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMalzemeAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mtxtMalzemeKodu);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 227);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Malzeme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudAdetDuzenle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTurDuzenle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAdDuzenle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtxtKodDuzenle);
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Location = new System.Drawing.Point(287, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 227);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Düzenle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Malzeme Kodu :";
            // 
            // nudAdetDuzenle
            // 
            this.nudAdetDuzenle.Location = new System.Drawing.Point(120, 134);
            this.nudAdetDuzenle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAdetDuzenle.Name = "nudAdetDuzenle";
            this.nudAdetDuzenle.Size = new System.Drawing.Size(100, 20);
            this.nudAdetDuzenle.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Malzeme Adı :";
            // 
            // txtTurDuzenle
            // 
            this.txtTurDuzenle.Location = new System.Drawing.Point(120, 102);
            this.txtTurDuzenle.Name = "txtTurDuzenle";
            this.txtTurDuzenle.Size = new System.Drawing.Size(100, 20);
            this.txtTurDuzenle.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Malzeme Türü :";
            // 
            // txtAdDuzenle
            // 
            this.txtAdDuzenle.Location = new System.Drawing.Point(120, 69);
            this.txtAdDuzenle.Name = "txtAdDuzenle";
            this.txtAdDuzenle.Size = new System.Drawing.Size(100, 20);
            this.txtAdDuzenle.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Adet :";
            // 
            // mtxtKodDuzenle
            // 
            this.mtxtKodDuzenle.Location = new System.Drawing.Point(120, 31);
            this.mtxtKodDuzenle.Mask = "0000000";
            this.mtxtKodDuzenle.Name = "mtxtKodDuzenle";
            this.mtxtKodDuzenle.Size = new System.Drawing.Size(100, 20);
            this.mtxtKodDuzenle.TabIndex = 14;
            this.mtxtKodDuzenle.ValidatingType = typeof(int);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(74, 170);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 38);
            this.btnDuzenle.TabIndex = 13;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // MalzemeDuzenleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MalzemeDuzenleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MalzemeDuzenleSil";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdetDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.TextBox txtMalzemeTuru;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.MaskedTextBox mtxtMalzemeKodu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAdetDuzenle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTurDuzenle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdDuzenle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtKodDuzenle;
        private System.Windows.Forms.Button btnDuzenle;
    }
}