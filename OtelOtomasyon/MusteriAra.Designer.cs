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
            this.DogumYeri = new System.Windows.Forms.TextBox();
            this.TelefonNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MedeniHal = new System.Windows.Forms.ComboBox();
            this.DogumTarih = new System.Windows.Forms.DateTimePicker();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MusteriAraİsim = new System.Windows.Forms.TabPage();
            this.MusteriAraİsimBul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.MusteriAraTC.Controls.Add(this.MusteriAraTCBul);
            this.MusteriAraTC.Controls.Add(this.DogumYeri);
            this.MusteriAraTC.Controls.Add(this.TelefonNo);
            this.MusteriAraTC.Controls.Add(this.label11);
            this.MusteriAraTC.Controls.Add(this.MedeniHal);
            this.MusteriAraTC.Controls.Add(this.DogumTarih);
            this.MusteriAraTC.Controls.Add(this.AdSoyad);
            this.MusteriAraTC.Controls.Add(this.label6);
            this.MusteriAraTC.Controls.Add(this.label4);
            this.MusteriAraTC.Controls.Add(this.label3);
            this.MusteriAraTC.Controls.Add(this.label2);
            this.MusteriAraTC.Controls.Add(this.textBox3);
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
            // 
            // DogumYeri
            // 
            this.DogumYeri.Location = new System.Drawing.Point(275, 217);
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Size = new System.Drawing.Size(200, 20);
            this.DogumYeri.TabIndex = 46;
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(275, 97);
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(200, 20);
            this.TelefonNo.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(160, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 44;
            this.label11.Text = "Telefon No:";
            // 
            // MedeniHal
            // 
            this.MedeniHal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedeniHal.FormattingEnabled = true;
            this.MedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.MedeniHal.Location = new System.Drawing.Point(275, 135);
            this.MedeniHal.Name = "MedeniHal";
            this.MedeniHal.Size = new System.Drawing.Size(200, 22);
            this.MedeniHal.TabIndex = 43;
            // 
            // DogumTarih
            // 
            this.DogumTarih.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogumTarih.Location = new System.Drawing.Point(275, 175);
            this.DogumTarih.Name = "DogumTarih";
            this.DogumTarih.Size = new System.Drawing.Size(200, 20);
            this.DogumTarih.TabIndex = 40;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(275, 57);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(200, 20);
            this.AdSoyad.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(160, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Medeni Hali:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(160, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(160, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Doğum Yeri:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ad Soyad:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 33;
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
            this.MusteriAraİsim.Controls.Add(this.MusteriAraİsimBul);
            this.MusteriAraİsim.Controls.Add(this.textBox1);
            this.MusteriAraİsim.Controls.Add(this.textBox2);
            this.MusteriAraİsim.Controls.Add(this.label1);
            this.MusteriAraİsim.Controls.Add(this.comboBox1);
            this.MusteriAraİsim.Controls.Add(this.dateTimePicker1);
            this.MusteriAraİsim.Controls.Add(this.textBox4);
            this.MusteriAraİsim.Controls.Add(this.label7);
            this.MusteriAraİsim.Controls.Add(this.label9);
            this.MusteriAraİsim.Controls.Add(this.label10);
            this.MusteriAraİsim.Controls.Add(this.label12);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 44;
            this.label1.Text = "Telefon No:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.comboBox1.Location = new System.Drawing.Point(275, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 22);
            this.comboBox1.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(160, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Medeni Hali:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(160, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 36;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(160, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "Doğum Yeri:";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(160, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 34;
            this.label12.Text = "TC Kimlik No:";
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
        private System.Windows.Forms.TextBox DogumYeri;
        private System.Windows.Forms.TextBox TelefonNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox MedeniHal;
        private System.Windows.Forms.DateTimePicker DogumTarih;
        private System.Windows.Forms.TextBox AdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage MusteriAraİsim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button MusteriAraTCBul;
        private System.Windows.Forms.Button MusteriAraİsimBul;

    }
}