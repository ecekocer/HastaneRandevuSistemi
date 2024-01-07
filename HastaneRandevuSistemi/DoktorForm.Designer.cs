namespace HastaneRandevuSistemi
{
    partial class DoktorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcKimlik = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.uzmanlik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // tcKimlik
            // 
            this.tcKimlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcKimlik.Location = new System.Drawing.Point(12, 135);
            this.tcKimlik.Name = "tcKimlik";
            this.tcKimlik.Size = new System.Drawing.Size(526, 22);
            this.tcKimlik.TabIndex = 10;
            // 
            // soyad
            // 
            this.soyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soyad.Location = new System.Drawing.Point(12, 82);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(526, 22);
            this.soyad.TabIndex = 9;
            // 
            // ad
            // 
            this.ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ad.Location = new System.Drawing.Point(12, 26);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(526, 22);
            this.ad.TabIndex = 8;
            // 
            // uzmanlik
            // 
            this.uzmanlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uzmanlik.FormattingEnabled = true;
            this.uzmanlik.Items.AddRange(new object[] {
            "Dahiliye",
            "Plastik Cerrahi",
            "Üroloji",
            "Kulak Burun Boğaz",
            "Göz",
            "Ortopedi",
            "Kadın Doğum",
            "Çocuk Doktoru"});
            this.uzmanlik.Location = new System.Drawing.Point(12, 191);
            this.uzmanlik.Name = "uzmanlik";
            this.uzmanlik.Size = new System.Drawing.Size(526, 24);
            this.uzmanlik.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Uzmanlık Alanı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "Doktor Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(12, 254);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(33, 16);
            this.logLabel.TabIndex = 17;
            this.logLabel.Text = "Text";
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uzmanlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcKimlik);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Name = "DoktorForm";
            this.Text = "DoktorFormcs";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcKimlik;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.ComboBox uzmanlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label logLabel;
    }
}