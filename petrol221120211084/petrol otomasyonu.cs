using System;
using System.Windows.Forms;
using PetrolOtomasyonSistemi; // PersonelYonetimi'nin tanımlı olduğu namespace'i ekleyin.


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Şube eklemek için buton
    private void btnSubeEkle_Click(object sender, EventArgs e)
    {
        SubeEkleme subeEklemeFormu = new SubeEkleme();
        subeEklemeFormu.Show();
    }

    // Kasa ekranını açmak için buton
    private void btnKasaEkrani_Click(object sender, EventArgs e)
    {
        KasaEkrani kasaEkraniFormu = new KasaEkrani();
        kasaEkraniFormu.Show();
    }

    // Gün sonu raporunu görmek için buton
    private void btnGunSonuRaporu_Click(object sender, EventArgs e)
    {
        GunSonuRaporu gunSonuRaporuFormu = new GunSonuRaporu();
        gunSonuRaporuFormu.Show();
    }

    // Personel yönetimi için buton
    private void btnPersonelYonetimi_Click(object sender, EventArgs e)
    {
        PersonelYonetimi personelYonetimiFormu = new PersonelYonetimi();
        personelYonetimiFormu.Show();
    }
}
