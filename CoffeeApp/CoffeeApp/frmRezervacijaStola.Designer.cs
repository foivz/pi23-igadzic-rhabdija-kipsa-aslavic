namespace CoffeeApp
{
    partial class frmRezervacijaStola
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
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(12, 55);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.RowHeadersWidth = 51;
            this.dgvStolovi.RowTemplate.Height = 24;
            this.dgvStolovi.Size = new System.Drawing.Size(592, 375);
            this.dgvStolovi.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(646, 55);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(154, 105);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj stol";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(646, 177);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(154, 94);
            this.btnPonisti.TabIndex = 2;
            this.btnPonisti.Text = "Poništi postojeću rezervaciju";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(646, 332);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(154, 98);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // frmRezervacijaStola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.dgvStolovi);
            this.Name = "frmRezervacijaStola";
            this.Text = "RezervacijaStola";
            this.Load += new System.EventHandler(this.frmRezervacijaStola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnIzlaz;
    }
}