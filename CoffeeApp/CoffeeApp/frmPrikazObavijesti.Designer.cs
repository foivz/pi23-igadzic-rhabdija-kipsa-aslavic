namespace CoffeeApp
{
    partial class frmPrikazObavijesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrikazObavijesti = new System.Windows.Forms.DataGridView();
            this.btnUredu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obavijesti:";
            // 
            // dgvPrikazObavijesti
            // 
            this.dgvPrikazObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazObavijesti.Location = new System.Drawing.Point(16, 30);
            this.dgvPrikazObavijesti.Name = "dgvPrikazObavijesti";
            this.dgvPrikazObavijesti.Size = new System.Drawing.Size(510, 196);
            this.dgvPrikazObavijesti.TabIndex = 1;
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(235, 280);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 2;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // frmPrikazObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 315);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.dgvPrikazObavijesti);
            this.Controls.Add(this.label1);
            this.Name = "frmPrikazObavijesti";
            this.Text = "Prikaz obavijesti";
            this.Load += new System.EventHandler(this.frmPrikazObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrikazObavijesti;
        private System.Windows.Forms.Button btnUredu;
    }
}