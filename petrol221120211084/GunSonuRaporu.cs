using System;
using System.Windows.Forms;

public partial class GunSonuRaporu : Form
{
    public GunSonuRaporu()
    {
        InitializeComponent();
    }

    // Gün sonu raporu gösterme
    public void RaporGoster(int subeID)
    {
        // Veritabanından raporu çekip ekranda göster
        MessageBox.Show($"Şube {subeID} için gün sonu raporu.");
    }
}
