namespace CoffeeApp
{
    partial class frmPregledZaliha
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
            this.CoffeeApp = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUrediPice = new System.Windows.Forms.Button();
            this.dgvUpravljajKatalogom = new System.Windows.Forms.DataGridView();
            this.btnDodajPice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljajKatalogom)).BeginInit();
            this.SuspendLayout();
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(12, 9);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 3;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(516, 350);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(199, 58);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(516, 68);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(199, 58);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "Izbriši piće";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUrediPice
            // 
            this.btnUrediPice.Location = new System.Drawing.Point(269, 431);
            this.btnUrediPice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediPice.Name = "btnUrediPice";
            this.btnUrediPice.Size = new System.Drawing.Size(199, 58);
            this.btnUrediPice.TabIndex = 5;
            this.btnUrediPice.Text = "Izmjeni piće";
            this.btnUrediPice.UseVisualStyleBackColor = true;
            this.btnUrediPice.Click += new System.EventHandler(this.btnUrediPice_Click);
            // 
            // dgvUpravljajKatalogom
            // 
            this.dgvUpravljajKatalogom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpravljajKatalogom.Location = new System.Drawing.Point(12, 68);
            this.dgvUpravljajKatalogom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUpravljajKatalogom.Name = "dgvUpravljajKatalogom";
            this.dgvUpravljajKatalogom.RowHeadersWidth = 51;
            this.dgvUpravljajKatalogom.RowTemplate.Height = 24;
            this.dgvUpravljajKatalogom.Size = new System.Drawing.Size(456, 340);
            this.dgvUpravljajKatalogom.TabIndex = 4;
            // 
            // btnDodajPice
            // 
            this.btnDodajPice.Location = new System.Drawing.Point(12, 431);
            this.btnDodajPice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajPice.Name = "btnDodajPice";
            this.btnDodajPice.Size = new System.Drawing.Size(199, 58);
            this.btnDodajPice.TabIndex = 8;
            this.btnDodajPice.Text = "Dodaj piće";
            this.btnDodajPice.UseVisualStyleBackColor = true;
            this.btnDodajPice.Click += new System.EventHandler(this.btnDodajPice_Click);
            // 
            // frmPregledZaliha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 506);
            this.Controls.Add(this.btnDodajPice);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUrediPice);
            this.Controls.Add(this.dgvUpravljajKatalogom);
            this.Controls.Add(this.CoffeeApp);
            this.Name = "frmPregledZaliha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregeled zaliha CoffeeApp";
            this.Load += new System.EventHandler(this.frmPregledZaliha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljajKatalogom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUrediPice;
        private System.Windows.Forms.DataGridView dgvUpravljajKatalogom;
        private System.Windows.Forms.Button btnDodajPice;
    }
}