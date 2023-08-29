namespace CoffeeApp
{
    partial class frmRadnoVrijeme
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
            this.dgvRadnoVrijeme = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVrijeme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnoVrijeme
            // 
            this.dgvRadnoVrijeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnoVrijeme.Location = new System.Drawing.Point(13, 13);
            this.dgvRadnoVrijeme.Name = "dgvRadnoVrijeme";
            this.dgvRadnoVrijeme.Size = new System.Drawing.Size(775, 330);
            this.dgvRadnoVrijeme.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(190, 374);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 63);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(484, 375);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 62);
            this.btnIzmjeni.TabIndex = 2;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // frmRadnoVrijeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvRadnoVrijeme);
            this.Name = "frmRadnoVrijeme";
            this.Text = "frmRadnoVrijeme";
            this.Load += new System.EventHandler(this.frmRadnoVrijeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVrijeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnoVrijeme;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzmjeni;
    }
}