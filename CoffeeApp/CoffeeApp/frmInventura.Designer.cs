
namespace CoffeeApp
{
    partial class frmInventura
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvInventura = new System.Windows.Forms.DataGridView();
            this.numUDKolicinaZaNaruciti = new System.Windows.Forms.NumericUpDown();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.CoffeeApp = new System.Windows.Forms.Label();
            this.lblDGV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDKolicinaZaNaruciti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(419, 324);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(149, 47);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvInventura
            // 
            this.dgvInventura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventura.Location = new System.Drawing.Point(12, 59);
            this.dgvInventura.Name = "dgvInventura";
            this.dgvInventura.Size = new System.Drawing.Size(555, 233);
            this.dgvInventura.TabIndex = 9;
            // 
            // numUDKolicinaZaNaruciti
            // 
            this.numUDKolicinaZaNaruciti.Location = new System.Drawing.Point(116, 339);
            this.numUDKolicinaZaNaruciti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDKolicinaZaNaruciti.Name = "numUDKolicinaZaNaruciti";
            this.numUDKolicinaZaNaruciti.Size = new System.Drawing.Size(120, 20);
            this.numUDKolicinaZaNaruciti.TabIndex = 10;
            this.numUDKolicinaZaNaruciti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(266, 324);
            this.btnNaruci.Margin = new System.Windows.Forms.Padding(2);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(149, 47);
            this.btnNaruci.TabIndex = 11;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 341);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(98, 13);
            this.lblKolicina.TabIndex = 12;
            this.lblKolicina.Text = "Količina za naručiti:";
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(11, 9);
            this.CoffeeApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 13;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // lblDGV
            // 
            this.lblDGV.AutoSize = true;
            this.lblDGV.Location = new System.Drawing.Point(9, 43);
            this.lblDGV.Name = "lblDGV";
            this.lblDGV.Size = new System.Drawing.Size(65, 13);
            this.lblDGV.TabIndex = 14;
            this.lblDGV.Text = "Manjci robe:";
            // 
            // frmInventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 382);
            this.Controls.Add(this.lblDGV);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.numUDKolicinaZaNaruciti);
            this.Controls.Add(this.dgvInventura);
            this.Controls.Add(this.btnOdustani);
            this.Name = "frmInventura";
            this.Text = "Inventura CoffeeApp";
            this.Load += new System.EventHandler(this.frmInventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDKolicinaZaNaruciti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvInventura;
        private System.Windows.Forms.NumericUpDown numUDKolicinaZaNaruciti;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.Label lblDGV;
    }
}