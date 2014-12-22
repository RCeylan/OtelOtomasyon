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
    public partial class BaslangicSayfa : Form
    {
        public BaslangicSayfa()
        {
            InitializeComponent();
        }

        private void MusteriİslemButon_Click(object sender, EventArgs e)
        {
            MusteriİslemleriForm Musteriİslem = new MusteriİslemleriForm();
            Musteriİslem.Show();
        }

        private void MusteriAraButon_Click(object sender, EventArgs e)
        {
            MusteriAra Musteriara = new MusteriAra();
            Musteriara.Show();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdaİslemleriButon_Click(object sender, EventArgs e)
        {
            Odalar Odalar = new Odalar();
            Odalar.Show();
        }
    }
}
