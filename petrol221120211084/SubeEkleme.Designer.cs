namespace PetrolOtomasyonSistemi
{
    partial class SubeEkleme
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnEkle;

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
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(30, 30);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(58, 13);
            this.lblSubeAdi.TabIndex = 0;
            this.lblSubeAdi.Text = "Şube Adı:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(30, 70);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 13);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 110);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(100, 30);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(200, 20);
            this.txtSubeAdi.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(100, 70);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 20);
            this.txtAdres.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(100, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // SubeEkleme
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnEkle);
            this.Name = "SubeEkleme";
            this.Text = "Şube Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
