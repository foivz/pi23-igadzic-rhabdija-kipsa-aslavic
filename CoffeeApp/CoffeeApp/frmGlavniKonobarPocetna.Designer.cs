namespace CoffeeApp
{
    partial class frmGlavniKonobarPocetna
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnKatalogPica = new System.Windows.Forms.Button();
            this.btnPromjeniRaspored = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(29, 36);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(627, 223);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnKatalogPica
            // 
            this.btnKatalogPica.Location = new System.Drawing.Point(257, 280);
            this.btnKatalogPica.Name = "btnKatalogPica";
            this.btnKatalogPica.Size = new System.Drawing.Size(165, 59);
            this.btnKatalogPica.TabIndex = 1;
            this.btnKatalogPica.Text = "Katalog pića";
            this.btnKatalogPica.UseVisualStyleBackColor = true;
            this.btnKatalogPica.Click += new System.EventHandler(this.btnKatalogPica_Click);
            // 
            // btnPromjeniRaspored
            // 
            this.btnPromjeniRaspored.Location = new System.Drawing.Point(29, 280);
            this.btnPromjeniRaspored.Name = "btnPromjeniRaspored";
            this.btnPromjeniRaspored.Size = new System.Drawing.Size(165, 59);
            this.btnPromjeniRaspored.TabIndex = 2;
            this.btnPromjeniRaspored.Text = "Promjeni raspored";
            this.btnPromjeniRaspored.UseVisualStyleBackColor = true;
            this.btnPromjeniRaspored.Click += new System.EventHandler(this.btnPromjeniRaspored_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(491, 280);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(165, 59);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // frmGlavniKonobarPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 383);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnPromjeniRaspored);
            this.Controls.Add(this.btnKatalogPica);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "frmGlavniKonobarPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni konobar CoffeeApp";
            this.Load += new System.EventHandler(this.frmGlavniKonobarPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnKatalogPica;
        private System.Windows.Forms.Button btnPromjeniRaspored;
        private System.Windows.Forms.Button btnOdjava;
    }
}