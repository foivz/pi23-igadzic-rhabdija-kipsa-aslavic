﻿namespace CoffeeApp
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.CoffeeApp = new System.Windows.Forms.Label();
            this.btnPregeldZaliha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpravljanjeKorisnicima
            // 
            this.btnUpravljanjeKorisnicima.Location = new System.Drawing.Point(167, 11);
            this.btnUpravljanjeKorisnicima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpravljanjeKorisnicima.Name = "btnUpravljanjeKorisnicima";
            this.btnUpravljanjeKorisnicima.Size = new System.Drawing.Size(171, 80);
            this.btnUpravljanjeKorisnicima.TabIndex = 1;
            this.btnUpravljanjeKorisnicima.Text = "Upravljanje korisnicima";
            this.btnUpravljanjeKorisnicima.UseVisualStyleBackColor = true;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(167, 263);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(171, 80);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(12, 97);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 162);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(16, 9);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 5;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // btnPregeldZaliha
            // 
            this.btnPregeldZaliha.Location = new System.Drawing.Point(167, 95);
            this.btnPregeldZaliha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPregeldZaliha.Name = "btnPregeldZaliha";
            this.btnPregeldZaliha.Size = new System.Drawing.Size(171, 80);
            this.btnPregeldZaliha.TabIndex = 6;
            this.btnPregeldZaliha.Text = "Pregled zaliha";
            this.btnPregeldZaliha.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pregled zaliha";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAdminPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPregeldZaliha);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnUpravljanjeKorisnicima);
            this.Name = "frmAdminPocetna";
            this.Text = "Admin CoffeeApp";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanjeKorisnicima;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.Button btnPregeldZaliha;
        private System.Windows.Forms.Button button1;
    }
}