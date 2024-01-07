namespace HastaneRandevuSistemi
{
    partial class HastaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.tcKimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hasta Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ad
            // 
            this.ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ad.Location = new System.Drawing.Point(12, 28);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(511, 22);
            this.ad.TabIndex = 1;
            // 
            // soyad
            // 
            this.soyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soyad.Location = new System.Drawing.Point(12, 84);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(511, 22);
            this.soyad.TabIndex = 2;
            // 
            // tcKimlik
            // 
            this.tcKimlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcKimlik.Location = new System.Drawing.Point(12, 137);
            this.tcKimlik.Name = "tcKimlik";
            this.tcKimlik.Size = new System.Drawing.Size(511, 22);
            this.tcKimlik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(15, 216);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(33, 16);
            this.logLabel.TabIndex = 9;
            this.logLabel.Text = "Text";
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 481);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcKimlik);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.button1);
            this.Name = "HastaForm";
            this.Text = "HastaForm";
            this.Load += new System.EventHandler(this.HastaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox tcKimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label logLabel;
    }
}