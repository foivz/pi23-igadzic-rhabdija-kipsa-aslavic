namespace CoffeeApp
{
    partial class frmDodajPice
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtbKolicina = new System.Windows.Forms.TextBox();
            this.txtbCijena = new System.Windows.Forms.TextBox();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(187, 13);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 48;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(322, 289);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(163, 50);
            this.btnOdustani.TabIndex = 47;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(68, 289);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(163, 50);
            this.btnSpremi.TabIndex = 46;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtbKolicina
            // 
            this.txtbKolicina.Location = new System.Drawing.Point(232, 223);
            this.txtbKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtbKolicina.Name = "txtbKolicina";
            this.txtbKolicina.Size = new System.Drawing.Size(253, 22);
            this.txtbKolicina.TabIndex = 45;
            // 
            // txtbCijena
            // 
            this.txtbCijena.Location = new System.Drawing.Point(232, 153);
            this.txtbCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtbCijena.Name = "txtbCijena";
            this.txtbCijena.Size = new System.Drawing.Size(253, 22);
            this.txtbCijena.TabIndex = 44;
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Location = new System.Drawing.Point(232, 92);
            this.txtbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(253, 22);
            this.txtbNaziv.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cijena pića:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Naziv pića";
            // 
            // frmDodajPice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 390);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtbKolicina);
            this.Controls.Add(this.txtbCijena);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajPice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj piće CoffeeApp";
            this.Load += new System.EventHandler(this.frmDodajPice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtbKolicina;
        private System.Windows.Forms.TextBox txtbCijena;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}