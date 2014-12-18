using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void GirisTarih_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
