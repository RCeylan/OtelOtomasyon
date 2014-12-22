namespace OtelOtomasyon
{
    partial class BaslangicSayfa
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
            this.MusteriİslemButon = new System.Windows.Forms.Button();
            this.OdaİslemleriButon = new System.Windows.Forms.Button();
            this.MusteriAraButon = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MusteriİslemButon
            // 
            this.MusteriİslemButon.Location = new System.Drawing.Point(65, 25);
            this.MusteriİslemButon.Name = "MusteriİslemButon";
            this.MusteriİslemButon.Size = new System.Drawing.Size(150, 50);
            this.MusteriİslemButon.TabIndex = 0;
            this.MusteriİslemButon.Text = "Müşteri İşlemleri";
            this.MusteriİslemButon.UseVisualStyleBackColor = true;
            this.MusteriİslemButon.Click += new System.EventHandler(this.MusteriİslemButon_Click);
            // 
            // OdaİslemleriButon
            // 
            this.OdaİslemleriButon.Location = new System.Drawing.Point(65, 81);
            this.OdaİslemleriButon.Name = "OdaİslemleriButon";
            this.OdaİslemleriButon.Size = new System.Drawing.Size(150, 50);
            this.OdaİslemleriButon.TabIndex = 1;
            this.OdaİslemleriButon.Text = "Oda İşlemleri";
            this.OdaİslemleriButon.UseVisualStyleBackColor = true;
            this.OdaİslemleriButon.Click += new System.EventHandler(this.OdaİslemleriButon_Click);
            // 
            // MusteriAraButon
            // 
            this.MusteriAraButon.Location = new System.Drawing.Point(65, 137);
            this.MusteriAraButon.Name = "MusteriAraButon";
            this.MusteriAraButon.Size = new System.Drawing.Size(150, 50);
            this.MusteriAraButon.TabIndex = 2;
            this.MusteriAraButon.Text = "Müşteri Ara";
            this.MusteriAraButon.UseVisualStyleBackColor = true;
            this.MusteriAraButon.Click += new System.EventHandler(this.MusteriAraButon_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(197, 235);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(75, 23);
            this.Cikis.TabIndex = 3;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // BaslangicSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.MusteriAraButon);
            this.Controls.Add(this.OdaİslemleriButon);
            this.Controls.Add(this.MusteriİslemButon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaslangicSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MusteriİslemButon;
        private System.Windows.Forms.Button OdaİslemleriButon;
        private System.Windows.Forms.Button MusteriAraButon;
        private System.Windows.Forms.Button Cikis;
    }
}