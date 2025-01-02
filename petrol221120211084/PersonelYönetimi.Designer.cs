using System;
using System.Windows.Forms;

namespace PetrolOtomasyonSistemi
{
    partial class PersonelYonetimi
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnEkle;
        private TextBox txtAd;
        private TextBox txtPozisyon;
        private NumericUpDown numericMaas;

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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.numericMaas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaas)).BeginInit();
            this.SuspendLayout();

            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(100, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Location = new System.Drawing.Point(100, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.Text = "Ad";
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);

            // 
            // txtPozisyon
            // 
            this.txtPozisyon.ForeColor = System.Drawing.Color.Gray;
            this.txtPozisyon.Location = new System.Drawing.Point(100, 60);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(200, 20);
            this.txtPozisyon.TabIndex = 2;
            this.txtPozisyon.Text = "Pozisyon";
            this.txtPozisyon.Enter += new System.EventHandler(this.txtPozisyon_Enter);
            this.txtPozisyon.Leave += new System.EventHandler(this.txtPozisyon_Leave);

            // 
            // numericMaas
            // 
            this.numericMaas.Location = new System.Drawing.Point(100, 90);
            this.numericMaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMaas.Name = "numericMaas";
            this.numericMaas.Size = new System.Drawing.Size(200, 20);
            this.numericMaas.TabIndex = 3;
            this.numericMaas.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});

            // 
            // PersonelYonetimi
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.numericMaas);
            this.Name = "PersonelYonetimi";
            this.Text = "Personel Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.numericMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
