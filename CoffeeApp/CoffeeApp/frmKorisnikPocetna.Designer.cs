namespace CoffeeApp
{
    partial class frmKorisnikPocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOdabranaPica = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnRezervirajStol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ponuda pića:";
            // 
            // dgvOdabranaPica
            // 
            this.dgvOdabranaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabranaPica.Location = new System.Drawing.Point(660, 47);
            this.dgvOdabranaPica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOdabranaPica.Name = "dgvOdabranaPica";
            this.dgvOdabranaPica.RowHeadersWidth = 51;
            this.dgvOdabranaPica.RowTemplate.Height = 24;
            this.dgvOdabranaPica.Size = new System.Drawing.Size(347, 276);
            this.dgvOdabranaPica.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(482, 47);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 51);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj u nardžbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(482, 120);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(145, 51);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Pošalji narudžbu";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Odabrana pića:";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(482, 197);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(145, 51);
            this.btnIzbrisi.TabIndex = 10;
            this.btnIzbrisi.Text = "Izbriši piće";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Location = new System.Drawing.Point(482, 351);
            this.btnOdjaviSe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(145, 51);
            this.btnOdjaviSe.TabIndex = 11;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(19, 47);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.RowTemplate.Height = 24;
            this.dgvArtikli.Size = new System.Drawing.Size(425, 276);
            this.dgvArtikli.TabIndex = 5;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // btnRezervirajStol
            // 
            this.btnRezervirajStol.Location = new System.Drawing.Point(482, 272);
            this.btnRezervirajStol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRezervirajStol.Name = "btnRezervirajStol";
            this.btnRezervirajStol.Size = new System.Drawing.Size(145, 51);
            this.btnRezervirajStol.TabIndex = 12;
            this.btnRezervirajStol.Text = "Rezerviraj Stol";
            this.btnRezervirajStol.UseVisualStyleBackColor = true;
            this.btnRezervirajStol.Click += new System.EventHandler(this.btnRezervirajStol_Click);
            // 
            // frmKorisnikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 447);
            this.Controls.Add(this.btnRezervirajStol);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOdabranaPica);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKorisnikPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeApp";
            this.Load += new System.EventHandler(this.frmKorisnikPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOdabranaPica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnRezervirajStol;
    }
}