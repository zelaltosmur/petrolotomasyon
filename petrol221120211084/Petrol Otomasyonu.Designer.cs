partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnSubeEkle;
    private System.Windows.Forms.Button btnKasaEkrani;
    private System.Windows.Forms.Button btnGunSonuRaporu;
    private System.Windows.Forms.Button btnPersonelYonetimi;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnSubeEkle = new System.Windows.Forms.Button();
        this.btnKasaEkrani = new System.Windows.Forms.Button();
        this.btnGunSonuRaporu = new System.Windows.Forms.Button();
        this.btnPersonelYonetimi = new System.Windows.Forms.Button();

        this.SuspendLayout();

        // 
        // btnSubeEkle
        // 
        this.btnSubeEkle.Location = new System.Drawing.Point(100, 100);
        this.btnSubeEkle.Name = "btnSubeEkle";
        this.btnSubeEkle.Size = new System.Drawing.Size(150, 50);
        this.btnSubeEkle.TabIndex = 0;
        this.btnSubeEkle.Text = "Şube Ekle";
        this.btnSubeEkle.UseVisualStyleBackColor = true;
        this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);

        // 
        // btnKasaEkrani
        // 
        this.btnKasaEkrani.Location = new System.Drawing.Point(100, 160);
        this.btnKasaEkrani.Name = "btnKasaEkrani";
        this.btnKasaEkrani.Size = new System.Drawing.Size(150, 50);
        this.btnKasaEkrani.TabIndex = 1;
        this.btnKasaEkrani.Text = "Kasa Ekranı";
        this.btnKasaEkrani.UseVisualStyleBackColor = true;
        this.btnKasaEkrani.Click += new System.EventHandler(this.btnKasaEkrani_Click);

        // 
        // btnGunSonuRaporu
        // 
        this.btnGunSonuRaporu.Location = new System.Drawing.Point(100, 220);
        this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
        this.btnGunSonuRaporu.Size = new System.Drawing.Size(150, 50);
        this.btnGunSonuRaporu.TabIndex = 2;
        this.btnGunSonuRaporu.Text = "Gün Sonu Raporu";
        this.btnGunSonuRaporu.UseVisualStyleBackColor = true;
        this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);

        // 
        // btnPersonelYonetimi
        // 
        this.btnPersonelYonetimi.Location = new System.Drawing.Point(100, 280);
        this.btnPersonelYonetimi.Name = "btnPersonelYonetimi";
        this.btnPersonelYonetimi.Size = new System.Drawing.Size(150, 50);
        this.btnPersonelYonetimi.TabIndex = 3;
        this.btnPersonelYonetimi.Text = "Personel Yönetimi";
        this.btnPersonelYonetimi.UseVisualStyleBackColor = true;
        this.btnPersonelYonetimi.Click += new System.EventHandler(this.btnPersonelYonetimi_Click);

        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnPersonelYonetimi);
        this.Controls.Add(this.btnGunSonuRaporu);
        this.Controls.Add(this.btnKasaEkrani);
        this.Controls.Add(this.btnSubeEkle);
        this.Name = "Form1";
        this.Text = "Petrol Otomasyon Sistemi";
        this.ResumeLayout(false);
    }
}
