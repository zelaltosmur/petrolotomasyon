using System;
using System.Windows.Forms;

public partial class GunSonuRaporu : Form
{
    private Button btnGoster;
    private void InitializeComponent()
    {
        this.btnGoster = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // 
        // btnGoster
        // 
        this.btnGoster.Location = new System.Drawing.Point(100, 100);
        this.btnGoster.Name = "btnGoster";
        this.btnGoster.Size = new System.Drawing.Size(150, 30);
        this.btnGoster.TabIndex = 0;
        this.btnGoster.Text = "Gün Sonu Raporu Göster";
        this.btnGoster.UseVisualStyleBackColor = true;
        this.btnGoster.Click += new System.EventHandler(this.BtnGoster_Click);

        // 
        // GunSonuRaporu
        // 
        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.btnGoster);
        this.Name = "GunSonuRaporu";
        this.Text = "Gün Sonu Raporu";
        this.ResumeLayout(false);
    }

    private void BtnGoster_Click(object sender, EventArgs e)
    {
        int subeID = 1; // Örnek olarak bir şube ID
        RaporGoster(subeID); // Gün sonu raporunu göster
    }
}
