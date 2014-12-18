namespace OtelOtomasyon
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MusteriGiris = new System.Windows.Forms.TabPage();
            this.MusteriAyrilis = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TCKimlik = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.DogumTarih = new System.Windows.Forms.DateTimePicker();
            this.OnayBay = new System.Windows.Forms.CheckBox();
            this.OnayBayan = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MedeniHal = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GirisTarih = new System.Windows.Forms.DateTimePicker();
            this.CikisTarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.KalinacakGun = new System.Windows.Forms.TextBox();
            this.OdaButon = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TelefonNo = new System.Windows.Forms.TextBox();
            this.DogumYeri = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.MusteriGiris.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MusteriGiris);
            this.tabControl1.Controls.Add(this.MusteriAyrilis);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // MusteriGiris
            // 
            this.MusteriGiris.Controls.Add(this.groupBox1);
            this.MusteriGiris.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriGiris.Location = new System.Drawing.Point(4, 23);
            this.MusteriGiris.Name = "MusteriGiris";
            this.MusteriGiris.Padding = new System.Windows.Forms.Padding(3);
            this.MusteriGiris.Size = new System.Drawing.Size(776, 433);
            this.MusteriGiris.TabIndex = 0;
            this.MusteriGiris.Text = "Müşteri Girişi";
            this.MusteriGiris.UseVisualStyleBackColor = true;
            // 
            // MusteriAyrilis
            // 
            this.MusteriAyrilis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAyrilis.Location = new System.Drawing.Point(4, 23);
            this.MusteriAyrilis.Name = "MusteriAyrilis";
            this.MusteriAyrilis.Padding = new System.Windows.Forms.Padding(3);
            this.MusteriAyrilis.Size = new System.Drawing.Size(776, 433);
            this.MusteriAyrilis.TabIndex = 1;
            this.MusteriAyrilis.Text = "Müşteri Ayrılış";
            this.MusteriAyrilis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.DogumYeri);
            this.groupBox1.Controls.Add(this.TelefonNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.MedeniHal);
            this.groupBox1.Controls.Add(this.OnayBayan);
            this.groupBox1.Controls.Add(this.OnayBay);
            this.groupBox1.Controls.Add(this.DogumTarih);
            this.groupBox1.Controls.Add(this.AdSoyad);
            this.groupBox1.Controls.Add(this.TCKimlik);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Yeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medeni Hali:";
            // 
            // TCKimlik
            // 
            this.TCKimlik.Location = new System.Drawing.Point(120, 37);
            this.TCKimlik.Name = "TCKimlik";
            this.TCKimlik.Size = new System.Drawing.Size(200, 20);
            this.TCKimlik.TabIndex = 6;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(120, 77);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(200, 20);
            this.AdSoyad.TabIndex = 7;
            // 
            // DogumTarih
            // 
            this.DogumTarih.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogumTarih.Location = new System.Drawing.Point(120, 195);
            this.DogumTarih.Name = "DogumTarih";
            this.DogumTarih.Size = new System.Drawing.Size(200, 20);
            this.DogumTarih.TabIndex = 8;
            // 
            // OnayBay
            // 
            this.OnayBay.AutoSize = true;
            this.OnayBay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnayBay.Location = new System.Drawing.Point(120, 279);
            this.OnayBay.Name = "OnayBay";
            this.OnayBay.Size = new System.Drawing.Size(45, 18);
            this.OnayBay.TabIndex = 9;
            this.OnayBay.Text = "Bay";
            this.OnayBay.UseVisualStyleBackColor = true;
            // 
            // OnayBayan
            // 
            this.OnayBayan.AutoSize = true;
            this.OnayBayan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnayBayan.Location = new System.Drawing.Point(193, 279);
            this.OnayBayan.Name = "OnayBayan";
            this.OnayBayan.Size = new System.Drawing.Size(57, 18);
            this.OnayBayan.TabIndex = 10;
            this.OnayBayan.Text = "Bayan";
            this.OnayBayan.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MedeniHal
            // 
            this.MedeniHal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedeniHal.FormattingEnabled = true;
            this.MedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.MedeniHal.Location = new System.Drawing.Point(120, 157);
            this.MedeniHal.Name = "MedeniHal";
            this.MedeniHal.Size = new System.Drawing.Size(130, 22);
            this.MedeniHal.TabIndex = 11;
            this.MedeniHal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.OdaButon);
            this.groupBox2.Controls.Add(this.KalinacakGun);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CikisTarih);
            this.groupBox2.Controls.Add(this.GirisTarih);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(481, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Verilen Oda:";
            // 
            // GirisTarih
            // 
            this.GirisTarih.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisTarih.Location = new System.Drawing.Point(156, 60);
            this.GirisTarih.Name = "GirisTarih";
            this.GirisTarih.Size = new System.Drawing.Size(107, 20);
            this.GirisTarih.TabIndex = 2;
            this.GirisTarih.ValueChanged += new System.EventHandler(this.GirisTarih_ValueChanged);
            // 
            // CikisTarih
            // 
            this.CikisTarih.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisTarih.Location = new System.Drawing.Point(156, 140);
            this.CikisTarih.Name = "CikisTarih";
            this.CikisTarih.Size = new System.Drawing.Size(107, 20);
            this.CikisTarih.TabIndex = 3;
            this.CikisTarih.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Geliş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Çıkış Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(17, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "Kalınacak Gün:";
            // 
            // KalinacakGun
            // 
            this.KalinacakGun.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalinacakGun.Location = new System.Drawing.Point(156, 100);
            this.KalinacakGun.Name = "KalinacakGun";
            this.KalinacakGun.Size = new System.Drawing.Size(107, 20);
            this.KalinacakGun.TabIndex = 7;
            this.KalinacakGun.TextChanged += new System.EventHandler(this.KalinacakGun_TextChanged);
            // 
            // OdaButon
            // 
            this.OdaButon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaButon.Location = new System.Drawing.Point(249, 17);
            this.OdaButon.Name = "OdaButon";
            this.OdaButon.Size = new System.Drawing.Size(14, 23);
            this.OdaButon.TabIndex = 8;
            this.OdaButon.Text = "...";
            this.OdaButon.UseVisualStyleBackColor = true;
            this.OdaButon.Click += new System.EventHandler(this.OdaButon_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefon No:";
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(120, 119);
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(200, 20);
            this.TelefonNo.TabIndex = 13;
            // 
            // DogumYeri
            // 
            this.DogumYeri.Location = new System.Drawing.Point(120, 237);
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Size = new System.Drawing.Size(200, 20);
            this.DogumYeri.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oda 1",
            "Oda 2",
            "Oda 3",
            "Oda 4",
            "Oda 5",
            "Oda 6",
            "Oda 7",
            "Oda 8",
            "Oda 9",
            "Oda 10"});
            this.comboBox1.Location = new System.Drawing.Point(156, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 22);
            this.comboBox1.TabIndex = 9;
            // 
            // Kaydet
            // 
            this.Kaydet.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(669, 312);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 50);
            this.Kaydet.TabIndex = 15;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            // 
            // Temizle
            // 
            this.Temizle.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(565, 312);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(75, 50);
            this.Temizle.TabIndex = 16;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Otel Otomasyon";
            this.tabControl1.ResumeLayout(false);
            this.MusteriGiris.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MusteriGiris;
        private System.Windows.Forms.TabPage MusteriAyrilis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox MedeniHal;
        private System.Windows.Forms.CheckBox OnayBayan;
        private System.Windows.Forms.CheckBox OnayBay;
        private System.Windows.Forms.DateTimePicker DogumTarih;
        private System.Windows.Forms.TextBox AdSoyad;
        private System.Windows.Forms.TextBox TCKimlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker CikisTarih;
        private System.Windows.Forms.DateTimePicker GirisTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KalinacakGun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DogumYeri;
        private System.Windows.Forms.TextBox TelefonNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OdaButon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Kaydet;


    }
}

