namespace OtelOtomasyon
{
    partial class MusteriAra
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MusteriAraTC = new System.Windows.Forms.TabPage();
            this.MusteriAraTCBul = new System.Windows.Forms.Button();
            this.TCBul = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MusteriAraİsim = new System.Windows.Forms.TabPage();
            this.MusteriAraİsimBul = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.İsmeGoreAraList = new System.Windows.Forms.ListView();
            this.TCGoreAraList = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.MusteriAraTC.SuspendLayout();
            this.MusteriAraİsim.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MusteriAraTC);
            this.tabControl1.Controls.Add(this.MusteriAraİsim);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // MusteriAraTC
            // 
            this.MusteriAraTC.Controls.Add(this.TCGoreAraList);
            this.MusteriAraTC.Controls.Add(this.MusteriAraTCBul);
            this.MusteriAraTC.Controls.Add(this.TCBul);
            this.MusteriAraTC.Controls.Add(this.label14);
            this.MusteriAraTC.Location = new System.Drawing.Point(4, 22);
            this.MusteriAraTC.Name = "MusteriAraTC";
            this.MusteriAraTC.Padding = new System.Windows.Forms.Padding(3);
            this.MusteriAraTC.Size = new System.Drawing.Size(612, 310);
            this.MusteriAraTC.TabIndex = 0;
            this.MusteriAraTC.Text = "TC Kimlik No\'ya Göre Ara";
            this.MusteriAraTC.UseVisualStyleBackColor = true;
            // 
            // MusteriAraTCBul
            // 
            this.MusteriAraTCBul.Location = new System.Drawing.Point(416, 15);
            this.MusteriAraTCBul.Name = "MusteriAraTCBul";
            this.MusteriAraTCBul.Size = new System.Drawing.Size(59, 20);
            this.MusteriAraTCBul.TabIndex = 48;
            this.MusteriAraTCBul.Text = "Bul";
            this.MusteriAraTCBul.UseVisualStyleBackColor = true;
            this.MusteriAraTCBul.Click += new System.EventHandler(this.MusteriAraTCBul_Click);
            // 
            // TCBul
            // 
            this.TCBul.Location = new System.Drawing.Point(210, 15);
            this.TCBul.Name = "TCBul";
            this.TCBul.Size = new System.Drawing.Size(200, 20);
            this.TCBul.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(75, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "TC Kimlik No Girin:";
            // 
            // MusteriAraİsim
            // 
            this.MusteriAraİsim.Controls.Add(this.İsmeGoreAraList);
            this.MusteriAraİsim.Controls.Add(this.MusteriAraİsimBul);
            this.MusteriAraİsim.Controls.Add(this.textBox5);
            this.MusteriAraİsim.Controls.Add(this.label13);
            this.MusteriAraİsim.Location = new System.Drawing.Point(4, 22);
            this.MusteriAraİsim.Name = "MusteriAraİsim";
            this.MusteriAraİsim.Padding = new System.Windows.Forms.Padding(3);
            this.MusteriAraİsim.Size = new System.Drawing.Size(612, 310);
            this.MusteriAraİsim.TabIndex = 1;
            this.MusteriAraİsim.Text = "İsme Göre Ara";
            this.MusteriAraİsim.UseVisualStyleBackColor = true;
            // 
            // MusteriAraİsimBul
            // 
            this.MusteriAraİsimBul.Location = new System.Drawing.Point(416, 15);
            this.MusteriAraİsimBul.Name = "MusteriAraİsimBul";
            this.MusteriAraİsimBul.Size = new System.Drawing.Size(59, 20);
            this.MusteriAraİsimBul.TabIndex = 47;
            this.MusteriAraİsimBul.Text = "Bul";
            this.MusteriAraİsimBul.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(210, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(75, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "İsim Giriniz:";
            // 
            // İsmeGoreAraList
            // 
            this.İsmeGoreAraList.Location = new System.Drawing.Point(5, 55);
            this.İsmeGoreAraList.Name = "İsmeGoreAraList";
            this.İsmeGoreAraList.Size = new System.Drawing.Size(615, 260);
            this.İsmeGoreAraList.TabIndex = 48;
            this.İsmeGoreAraList.UseCompatibleStateImageBehavior = false;
            // 
            // TCGoreAraList
            // 
            this.TCGoreAraList.Location = new System.Drawing.Point(5, 55);
            this.TCGoreAraList.Name = "TCGoreAraList";
            this.TCGoreAraList.Size = new System.Drawing.Size(615, 260);
            this.TCGoreAraList.TabIndex = 49;
            this.TCGoreAraList.UseCompatibleStateImageBehavior = false;
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 336);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Arama";
            this.tabControl1.ResumeLayout(false);
            this.MusteriAraTC.ResumeLayout(false);
            this.MusteriAraTC.PerformLayout();
            this.MusteriAraİsim.ResumeLayout(false);
            this.MusteriAraİsim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MusteriAraTC;
        private System.Windows.Forms.TextBox TCBul;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage MusteriAraİsim;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button MusteriAraTCBul;
        private System.Windows.Forms.Button MusteriAraİsimBul;
        private System.Windows.Forms.ListView TCGoreAraList;
        private System.Windows.Forms.ListView İsmeGoreAraList;

    }
}