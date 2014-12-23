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
    public partial class MusteriAra : Form
    {
       
        public MusteriAra()
        {
            InitializeComponent();
        }
        public void MusteriArama()
        {

            DataTable veriler = new DataTable();


            TCGoreAraList.View = View.Details;

            //TCGoreAraList.Columns.Clear();
            TCGoreAraList.Columns.Add("Adı Soyadı", 150, HorizontalAlignment.Left);
            TCGoreAraList.Columns.Add("TC Kimlik NO", 100, HorizontalAlignment.Left);
            TCGoreAraList.Columns.Add("Doğum Tarihi", 100, HorizontalAlignment.Left);
            TCGoreAraList.Columns.Add("Telefon Numarası", 100, HorizontalAlignment.Left);

            try
            {
                Ayarlar.BaglantiAc();

                SqlCommand komut = new SqlCommand("SELECT TOP 10 ROW_NUMBER() OVER AdSoyad as [Adı Soyadı], TCKimlik as [TC Kimlik NO], DogumTarih as [Doğum Tarihi], TelefonNo as [Telefon Numarası] FROM MusteriBilgileri WHERE TCKimlik = '"+TCBul.Text.ToString() +"'" , Ayarlar.baglanti);

                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                TCGoreAraList.Items.Clear();

                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    DataRow satir = veriler.Rows[i];

                    if (satir.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(satir["Adı Soyadı"].ToString());
                        item.SubItems.Add(satir["TC Kimlik NO"].ToString());
                        item.SubItems.Add(satir["Doğum Tarihi"].ToString());
                        item.SubItems.Add(satir["Telefon Numarası"].ToString());

                        TCGoreAraList.Items.Add(item);
                    }
                }

                Ayarlar.BaglantiKapat();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void MusteriAraTCBul_Click(object sender, EventArgs e)
        {
            MusteriArama();
        }
    }
}
