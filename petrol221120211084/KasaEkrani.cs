// KasaEkrani.cs
using System;
using System.Windows.Forms;

public partial class KasaEkrani : Form
{
    public KasaEkrani()
    {
        InitializeComponent();
    }

    private void btnOnayla_Click(object sender, EventArgs e)
    {
        // Formdan değerleri al
        string satisID = txtSatisID.Text;
        string plaka = txtPlaka.Text;
        decimal tutar;

        // Tutarın geçerli olup olmadığını kontrol et
        if (!decimal.TryParse(txtTutar.Text, out tutar))
        {
            MessageBox.Show("Geçerli bir tutar girin.");
            return;
        }

        // Yakıt talebi ve ödeme kontrolü burada yapılabilir

        // Satışı onayla ve fişi oluştur
        Satis satis = new Satis();
        satis.FisOlustur(satisID, plaka, tutar);

        MessageBox.Show("Satış onaylandı.");
    }
}

// Satis.cs
public class Satis
{
    public void FisOlustur(string satisID, string plaka, decimal tutar)
    {
        // Fiş oluşturma işlemi
        MessageBox.Show($"Fiş oluşturuldu: SatisID: {satisID}, Plaka: {plaka}, Tutar: {tutar}");
    }
}
