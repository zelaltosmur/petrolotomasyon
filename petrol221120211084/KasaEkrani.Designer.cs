partial class KasaEkrani
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtPlaka;
    private System.Windows.Forms.TextBox txtTutar;
    private System.Windows.Forms.TextBox txtSatisID;
    private System.Windows.Forms.Button btnOnayla;
    private System.Windows.Forms.Label lblPlaka;
    private System.Windows.Forms.Label lblTutar;
    private System.Windows.Forms.Label lblSatisID;

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
        this.txtPlaka = new System.Windows.Forms.TextBox();
        this.txtTutar = new System.Windows.Forms.TextBox();
        this.txtSatisID = new System.Windows.Forms.TextBox();
        this.btnOnayla = new System.Windows.Forms.Button();
        this.lblPlaka = new System.Windows.Forms.Label();
        this.lblTutar = new System.Windows.Forms.Label();
        this.lblSatisID = new System.Windows.Forms.Label();

        this.SuspendLayout();

        // 
        // txtPlaka
        // 
        this.txtPlaka.Location = new System.Drawing.Point(150, 50);
        this.txtPlaka.Name = "txtPlaka";
        this.txtPlaka.Size = new System.Drawing.Size(200, 20);
        this.txtPlaka.TabIndex = 0;

        // 
        // txtTutar
        // 
        this.txtTutar.Location = new System.Drawing.Point(150, 100);
        this.txtTutar.Name = "txtTutar";
        this.txtTutar.Size = new System.Drawing.Size(200, 20);
        this.txtTutar.TabIndex = 1;

        // 
        // txtSatisID
        // 
        this.txtSatisID.Location = new System.Drawing.Point(150, 150);
        this.txtSatisID.Name = "txtSatisID";
        this.txtSatisID.Size = new System.Drawing.Size(200, 20);
        this.txtSatisID.TabIndex = 2;

        // 
        // btnOnayla
        // 
        this.btnOnayla.Location = new System.Drawing.Point(150, 200);
        this.btnOnayla.Name = "btnOnayla";
        this.btnOnayla.Size = new System.Drawing.Size(100, 30);
        this.btnOnayla.TabIndex = 3;
        this.btnOnayla.Text = "Satışı Onayla";
        this.btnOnayla.UseVisualStyleBackColor = true;
        this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);

        // 
        // lblPlaka
        // 
        this.lblPlaka.AutoSize = true;
        this.lblPlaka.Location = new System.Drawing.Point(50, 50);
        this.lblPlaka.Name = "lblPlaka";
        this.lblPlaka.Size = new System.Drawing.Size(36, 13);
        this.lblPlaka.TabIndex = 4;
        this.lblPlaka.Text = "Plaka:";

        // 
        // lblTutar
        // 
        this.lblTutar.AutoSize = true;
        this.lblTutar.Location = new System.Drawing.Point(50, 100);
        this.lblTutar.Name = "lblTutar";
        this.lblTutar.Size = new System.Drawing.Size(35, 13);
        this.lblTutar.TabIndex = 5;
        this.lblTutar.Text = "Tutar:";

        // 
        // lblSatisID
        // 
        this.lblSatisID.AutoSize = true;
        this.lblSatisID.Location = new System.Drawing.Point(50, 150);
        this.lblSatisID.Name = "lblSatisID";
        this.lblSatisID.Size = new System.Drawing.Size(54, 13);
        this.lblSatisID.TabIndex = 6;
        this.lblSatisID.Text = "Satış ID:";

        // 
        // KasaEkrani
        // 
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.Controls.Add(this.lblSatisID);
        this.Controls.Add(this.lblTutar);
        this.Controls.Add(this.lblPlaka);
        this.Controls.Add(this.btnOnayla);
        this.Controls.Add(this.txtSatisID);
        this.Controls.Add(this.txtTutar);
        this.Controls.Add(this.txtPlaka);
        this.Name = "KasaEkrani";
        this.Text = "Kasa Ekranı";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
