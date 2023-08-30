namespace CoffeeApp
{
    partial class frmDogadaji
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
            this.dgvDogadaji = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodajDogadaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogadaji
            // 
            this.dgvDogadaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadaji.Location = new System.Drawing.Point(13, 13);
            this.dgvDogadaji.Name = "dgvDogadaji";
            this.dgvDogadaji.Size = new System.Drawing.Size(775, 313);
            this.dgvDogadaji.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(13, 385);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 53);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodajDogadaj
            // 
            this.btnDodajDogadaj.Location = new System.Drawing.Point(712, 385);
            this.btnDodajDogadaj.Name = "btnDodajDogadaj";
            this.btnDodajDogadaj.Size = new System.Drawing.Size(75, 52);
            this.btnDodajDogadaj.TabIndex = 2;
            this.btnDodajDogadaj.Text = "Dodaj novi dogadaj";
            this.btnDodajDogadaj.UseVisualStyleBackColor = true;
            this.btnDodajDogadaj.Click += new System.EventHandler(this.btnDodajDogadaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(609, 385);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 45);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // frmDogadaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodajDogadaj);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvDogadaji);
            this.Name = "frmDogadaji";
            this.Text = "Događaji";
            this.Load += new System.EventHandler(this.frmDogadaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadaji;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDodajDogadaj;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}