namespace CoffeeApp
{
    partial class frmPromjenaRasporeda
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
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSmjena = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(81, 85);
            this.txtbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.Size = new System.Drawing.Size(154, 20);
            this.txtbPrezime.TabIndex = 11;
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(81, 35);
            this.txtbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.Size = new System.Drawing.Size(154, 20);
            this.txtbIme.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Smjena:";
            // 
            // cmbSmjena
            // 
            this.cmbSmjena.FormattingEnabled = true;
            this.cmbSmjena.Items.AddRange(new object[] {
            "Prijepodne",
            "Poslijepodne",
            "Vecer"});
            this.cmbSmjena.Location = new System.Drawing.Point(81, 139);
            this.cmbSmjena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSmjena.Name = "cmbSmjena";
            this.cmbSmjena.Size = new System.Drawing.Size(154, 21);
            this.cmbSmjena.TabIndex = 37;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(14, 191);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(109, 41);
            this.btnSpremi.TabIndex = 39;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(152, 191);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(109, 41);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmPromjenaRasporeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 269);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSmjena);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPromjenaRasporeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena rasporeda";
            this.Load += new System.EventHandler(this.frmPromjenaRasporeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSmjena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}