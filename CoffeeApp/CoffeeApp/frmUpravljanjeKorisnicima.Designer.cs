namespace CoffeeApp
{
    partial class frmUpravljanjeKorisnicima
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
            this.dgvUpravljanjeKorsincima = new System.Windows.Forms.DataGridView();
            this.btnUrediKorisnika = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeKorsincima)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpravljanjeKorsincima
            // 
            this.dgvUpravljanjeKorsincima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpravljanjeKorsincima.Location = new System.Drawing.Point(12, 11);
            this.dgvUpravljanjeKorsincima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUpravljanjeKorsincima.Name = "dgvUpravljanjeKorsincima";
            this.dgvUpravljanjeKorsincima.RowHeadersWidth = 51;
            this.dgvUpravljanjeKorsincima.RowTemplate.Height = 24;
            this.dgvUpravljanjeKorsincima.Size = new System.Drawing.Size(1315, 340);
            this.dgvUpravljanjeKorsincima.TabIndex = 1;
            // 
            // btnUrediKorisnika
            // 
            this.btnUrediKorisnika.Location = new System.Drawing.Point(12, 377);
            this.btnUrediKorisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediKorisnika.Name = "btnUrediKorisnika";
            this.btnUrediKorisnika.Size = new System.Drawing.Size(199, 58);
            this.btnUrediKorisnika.TabIndex = 2;
            this.btnUrediKorisnika.Text = "Izmjeni korisnika";
            this.btnUrediKorisnika.UseVisualStyleBackColor = true;
            this.btnUrediKorisnika.Click += new System.EventHandler(this.btnUrediKorisnika_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(254, 377);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(199, 58);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši korisnika";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(965, 377);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(199, 58);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmUpravljanjeKorisnicima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 504);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUrediKorisnika);
            this.Controls.Add(this.dgvUpravljanjeKorsincima);
            this.Name = "frmUpravljanjeKorisnicima";
            this.Text = "Upravljanje korisnicima";
            this.Load += new System.EventHandler(this.frmUpravljanjeKorisnicima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeKorsincima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpravljanjeKorsincima;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOdustani;
    }
}