using System;
using System.Windows.Forms;

namespace PetrolOtomasyonSistemi
{
    public partial class PersonelYonetimi : Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Personel ekleme işlemi burada yapılacak
            string ad = txtAd.Text;
            string pozisyon = txtPozisyon.Text;
            decimal maas = numericMaas.Value;

            // Personel ekleme işlemi burada yapılabilir, örneğin veritabanına kaydetme vs.

            MessageBox.Show($"Personel {ad} eklenmiştir.");
        }

        // Placeholder işlevini kendimiz ekliyoruz
        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "Ad")
            {
                txtAd.Text = "";
                txtAd.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Ad";
                txtAd.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPozisyon_Enter(object sender, EventArgs e)
        {
            if (txtPozisyon.Text == "Pozisyon")
            {
                txtPozisyon.Text = "";
                txtPozisyon.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPozisyon_Leave(object sender, EventArgs e)
        {
            if (txtPozisyon.Text == "")
            {
                txtPozisyon.Text = "Pozisyon";
                txtPozisyon.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
