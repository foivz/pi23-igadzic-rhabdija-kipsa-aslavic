namespace CoffeeApp
{
    partial class frmUrediKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrediKorisnika));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.CoffeeApp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(340, 555);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(163, 50);
            this.btnOdustani.TabIndex = 38;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(68, 555);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(163, 50);
            this.btnSpremi.TabIndex = 37;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 491);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Uloga :";
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Korisnik",
            "Konobar",
            "Glavni konobar"});
            this.cmbUloga.Location = new System.Drawing.Point(249, 489);
            this.cmbUloga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(253, 24);
            this.cmbUloga.TabIndex = 35;
            // 
            // txtbLozinka
            // 
            this.txtbLozinka.Location = new System.Drawing.Point(249, 413);
            this.txtbLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLozinka.Name = "txtbLozinka";
            this.txtbLozinka.Size = new System.Drawing.Size(253, 22);
            this.txtbLozinka.TabIndex = 34;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(249, 354);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.ReadOnly = true;
            this.txtbEmail.Size = new System.Drawing.Size(253, 22);
            this.txtbEmail.TabIndex = 33;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(249, 291);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(253, 22);
            this.txtbUsername.TabIndex = 32;
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(249, 221);
            this.txtbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.ReadOnly = true;
            this.txtbPrezime.Size = new System.Drawing.Size(253, 22);
            this.txtbPrezime.TabIndex = 31;
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(249, 160);
            this.txtbIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.ReadOnly = true;
            this.txtbIme.Size = new System.Drawing.Size(253, 22);
            this.txtbIme.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Loznika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime:";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(307, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 129);
            this.logo.TabIndex = 39;
            this.logo.TabStop = false;
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(30, 51);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 40;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // frmUrediKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 632);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtbLozinka);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUrediKorisnika";
            this.Text = "Uredi korisnika";
            this.Load += new System.EventHandler(this.frmUrediKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label CoffeeApp;
    }
}