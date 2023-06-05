namespace CoffeeApp
{
    partial class frmStolRezevacija
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
            this.lblStolovi = new System.Windows.Forms.Label();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(13, 64);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.RowHeadersWidth = 51;
            this.dgvStolovi.RowTemplate.Height = 24;
            this.dgvStolovi.Size = new System.Drawing.Size(576, 340);
            this.dgvStolovi.TabIndex = 0;
            // 
            // lblStolovi
            // 
            this.lblStolovi.AutoSize = true;
            this.lblStolovi.Location = new System.Drawing.Point(12, 45);
            this.lblStolovi.Name = "lblStolovi";
            this.lblStolovi.Size = new System.Drawing.Size(190, 16);
            this.lblStolovi.TabIndex = 1;
            this.lblStolovi.Text = "Dostupni stolovi za rezervaciju:";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(616, 64);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(149, 69);
            this.btnRezerviraj.TabIndex = 2;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(616, 340);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(149, 64);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(616, 139);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(149, 67);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Otkaži postojeću rezervaciju";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // frmStolRezevacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.lblStolovi);
            this.Controls.Add(this.dgvStolovi);
            this.Name = "frmStolRezevacija";
            this.Text = "Rezerviraj Stol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Label lblStolovi;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnOtkazi;
    }
}