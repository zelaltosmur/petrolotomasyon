using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolOtomasyonSistemi
{
    public partial class SubeEkleme : Form
    {
        public SubeEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Şube bilgilerini al
                string subeAdi = txtSubeAdi.Text;
                string adres = txtAdres.Text;
                string telefon = txtTelefon.Text;

                // Veritabanına ekleme
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-1R4TMPS;Database=PetrolOtomasyonDB;User Id=sa;Password=123456789;"))
                {
                    connection.Open();

                    string query = "INSERT INTO Sube (SubeAdi, Adres, Telefon) VALUES (@SubeAdi, @Adres, @Telefon)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubeAdi", subeAdi);
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@Telefon", telefon);

                        command.ExecuteNonQuery();
                    }
                }

                // Başarılı mesajı
                MessageBox.Show("Şube başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TextBox'ları temizle
                txtSubeAdi.Text = "";
                txtAdres.Text = "";
                txtTelefon.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
