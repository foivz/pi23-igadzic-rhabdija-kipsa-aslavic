namespace CoffeeApp
{
    partial class frmObavijesti
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
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Location = new System.Drawing.Point(13, 13);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.Size = new System.Drawing.Size(775, 344);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(676, 390);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(112, 48);
            this.btnNova.TabIndex = 1;
            this.btnNova.Text = "Nova Obavijest";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(558, 390);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(112, 48);
            this.btnIzbriši.TabIndex = 3;
            this.btnIzbriši.Text = "Izbriši";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(13, 390);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(112, 48);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.dgvObavijesti);
            this.Name = "frmObavijesti";
            this.Text = "frmObavijesti";
            this.Load += new System.EventHandler(this.frmObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnPovratak;
    }
}