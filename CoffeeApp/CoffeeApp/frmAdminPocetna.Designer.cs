namespace CoffeeApp
{
    partial class frmAdminPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPocetna));
            this.btnUpravljanjeKorisnicima = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.CoffeeApp = new System.Windows.Forms.Label();
            this.btnPregeldZaliha = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnPlacanjeNarudzbe = new System.Windows.Forms.Button();
            this.btnPromjeniRaspored = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpravljanjeKorisnicima
            // 
            this.btnUpravljanjeKorisnicima.Location = new System.Drawing.Point(124, 47);
            this.btnUpravljanjeKorisnicima.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpravljanjeKorisnicima.Name = "btnUpravljanjeKorisnicima";
            this.btnUpravljanjeKorisnicima.Size = new System.Drawing.Size(128, 65);
            this.btnUpravljanjeKorisnicima.TabIndex = 1;
            this.btnUpravljanjeKorisnicima.Text = "Upravljanje korisnicima";
            this.btnUpravljanjeKorisnicima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeKorisnicima.Click += new System.EventHandler(this.btnUpravljanjeKorisnicima_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(520, 328);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(128, 65);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(12, 9);
            this.CoffeeApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 5;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // btnPregeldZaliha
            // 
            this.btnPregeldZaliha.Location = new System.Drawing.Point(256, 47);
            this.btnPregeldZaliha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPregeldZaliha.Name = "btnPregeldZaliha";
            this.btnPregeldZaliha.Size = new System.Drawing.Size(128, 65);
            this.btnPregeldZaliha.TabIndex = 6;
            this.btnPregeldZaliha.Text = "Pregled zaliha";
            this.btnPregeldZaliha.UseVisualStyleBackColor = true;
            this.btnPregeldZaliha.Click += new System.EventHandler(this.btnPregeldZaliha_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(11, 15);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(94, 124);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // btnPlacanjeNarudzbe
            // 
            this.btnPlacanjeNarudzbe.Location = new System.Drawing.Point(256, 329);
            this.btnPlacanjeNarudzbe.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlacanjeNarudzbe.Name = "btnPlacanjeNarudzbe";
            this.btnPlacanjeNarudzbe.Size = new System.Drawing.Size(128, 65);
            this.btnPlacanjeNarudzbe.TabIndex = 9;
            this.btnPlacanjeNarudzbe.Text = "Plaćanje narudžbi";
            this.btnPlacanjeNarudzbe.UseVisualStyleBackColor = true;
            this.btnPlacanjeNarudzbe.Click += new System.EventHandler(this.btnPlacanjeNarudzbe_Click);
            // 
            // btnPromjeniRaspored
            // 
            this.btnPromjeniRaspored.Location = new System.Drawing.Point(17, 328);
            this.btnPromjeniRaspored.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromjeniRaspored.Name = "btnPromjeniRaspored";
            this.btnPromjeniRaspored.Size = new System.Drawing.Size(128, 65);
            this.btnPromjeniRaspored.TabIndex = 11;
            this.btnPromjeniRaspored.Text = "Promjeni raspored";
            this.btnPromjeniRaspored.UseVisualStyleBackColor = true;
            this.btnPromjeniRaspored.Click += new System.EventHandler(this.btnPromjeniRaspored_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(17, 143);
            this.dgvZaposlenici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(611, 181);
            this.dgvZaposlenici.TabIndex = 10;
            // 
            // frmAdminPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.btnPromjeniRaspored);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnPlacanjeNarudzbe);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnPregeldZaliha);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnUpravljanjeKorisnicima);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin CoffeeApp";
            this.Load += new System.EventHandler(this.frmAdminPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanjeKorisnicima;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.Button btnPregeldZaliha;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnPlacanjeNarudzbe;
        private System.Windows.Forms.Button btnPromjeniRaspored;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
    }
}