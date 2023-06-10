namespace CoffeeApp
{
    partial class frmPlacanjeNarudzbe
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnPlatiNarudzbu = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(23, 35);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.RowHeadersWidth = 51;
            this.dgvNarudzbe.RowTemplate.Height = 24;
            this.dgvNarudzbe.Size = new System.Drawing.Size(456, 346);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.SelectionChanged += new System.EventHandler(this.dgvNarudzbe_SelectionChanged);
            // 
            // btnPlatiNarudzbu
            // 
            this.btnPlatiNarudzbu.Location = new System.Drawing.Point(499, 222);
            this.btnPlatiNarudzbu.Name = "btnPlatiNarudzbu";
            this.btnPlatiNarudzbu.Size = new System.Drawing.Size(115, 66);
            this.btnPlatiNarudzbu.TabIndex = 1;
            this.btnPlatiNarudzbu.Text = "Plati narudžbu";
            this.btnPlatiNarudzbu.UseVisualStyleBackColor = true;
            this.btnPlatiNarudzbu.Click += new System.EventHandler(this.btnPlatiNarudzbu_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(499, 316);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(115, 65);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Narudžbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artikli izabrane narudžbe:";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(646, 35);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.RowTemplate.Height = 24;
            this.dgvArtikli.Size = new System.Drawing.Size(453, 346);
            this.dgvArtikli.TabIndex = 5;
            // 
            // frmPlacanjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 400);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPlatiNarudzbu);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "frmPlacanjeNarudzbe";
            this.Text = "Placanje Narudzbe";
            this.Load += new System.EventHandler(this.frmPlacanjeNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnPlatiNarudzbu;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvArtikli;
    }
}