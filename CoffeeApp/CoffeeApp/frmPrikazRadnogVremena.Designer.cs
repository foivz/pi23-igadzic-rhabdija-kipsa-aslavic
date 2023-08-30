namespace CoffeeApp
{
    partial class frmPrikazRadnogVremena
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
            this.dgvRadnoVrijemePrikaz = new System.Windows.Forms.DataGridView();
            this.btnURedu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVrijemePrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnoVrijemePrikaz
            // 
            this.dgvRadnoVrijemePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnoVrijemePrikaz.Location = new System.Drawing.Point(13, 13);
            this.dgvRadnoVrijemePrikaz.Name = "dgvRadnoVrijemePrikaz";
            this.dgvRadnoVrijemePrikaz.Size = new System.Drawing.Size(530, 199);
            this.dgvRadnoVrijemePrikaz.TabIndex = 0;
            // 
            // btnURedu
            // 
            this.btnURedu.Location = new System.Drawing.Point(249, 271);
            this.btnURedu.Name = "btnURedu";
            this.btnURedu.Size = new System.Drawing.Size(75, 23);
            this.btnURedu.TabIndex = 1;
            this.btnURedu.Text = "U redu";
            this.btnURedu.UseVisualStyleBackColor = true;
            this.btnURedu.Click += new System.EventHandler(this.btnURedu_Click);
            // 
            // frmPrikazRadnogVremena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 306);
            this.Controls.Add(this.btnURedu);
            this.Controls.Add(this.dgvRadnoVrijemePrikaz);
            this.Name = "frmPrikazRadnogVremena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazRadnogVremena";
            this.Load += new System.EventHandler(this.frmPrikazRadnogVremena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVrijemePrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnoVrijemePrikaz;
        private System.Windows.Forms.Button btnURedu;
    }
}