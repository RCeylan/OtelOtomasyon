using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
  
{ 
    
    public partial class MusteriİslemleriForm : Form
    {

       public SqlConnection baglanti;   


        public MusteriİslemleriForm()
        {
            InitializeComponent();
        }


        private void OdaButon_Click(object sender, EventArgs e)
        {
            Odalar MusteriKayit = new Odalar();
            MusteriKayit.Show();
        }

        private void KalinacakGun_TextChanged(object sender, EventArgs e)
        {
            TimeSpan tarih = new TimeSpan(int.Parse(KalinacakGun.Text), 0, 0, 0);
            DateTime yeni = GirisTarih.Value + tarih;
            CikisTarih.Value = yeni;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void BaglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        void BaglantiKapat()
        {
            baglanti.Close();
        }

        private void MusteriİslemleriForm_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=PC\\SA; Initial Catalog=OtelOtomasyonu; User id = sa; Password=1234; Integrated Security= True");
        }

        void Temizlik()
        {
            AdSoyad.Clear();
            TCKimlik.Clear();
            TelefonNo.Clear();
            DogumYeri.Clear();
        
            
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            Temizlik();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                BaglantiAc();
                SqlCommand komut = new SqlCommand("Insert Into MusteriBilgileri(TCKimlik, AdSoyad, TelefonNo, MedeniHal, DogumTarihi, DogumYeri, Cinsiyet) values (@TCKimlik, @AdSoyad, @TelefonNo, @MedeniHal, @DogumTarihi, @DogumYeri, @Cinsiyet)", baglanti);
                SqlCommand komut2 = new SqlCommand("Insert Into OdaKayitlari(OdaID, GirisTarihi, CikisTarihi) values (@OdaID, @GirisTarihi, @CikisTarihi)", baglanti);

                komut.Parameters.AddWithValue("@TCKimlik", TCKimlik.Text);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad.Text);
                komut.Parameters.AddWithValue("@TelefonNo", TelefonNo.Text);
                komut.Parameters.AddWithValue("@MedeniHal", MedeniHal.Text);
                komut.Parameters.AddWithValue("@DogumTarihi", DogumTarih.Value);
                komut.Parameters.AddWithValue("@DogumYeri", DogumYeri.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet.Text);

                komut2.Parameters.AddWithValue("@OdaID", MusteriGirisOdaSec.Text);
                komut2.Parameters.AddWithValue("@GirisTarihi", GirisTarih.Value);
                komut2.Parameters.AddWithValue("@CikisTarihi", CikisTarih.Value);
              

                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                BaglantiKapat();

                MessageBox.Show("Kayıt Başarılı!");
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }
            
        }

        private void TCKimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
