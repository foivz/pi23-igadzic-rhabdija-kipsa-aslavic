﻿namespace CoffeeApp
{
    partial class frmKorisnikPocetna
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
            this.dgvOdabranaPica = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaPica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ponuda pića:";
            // 
            // dgvOdabranaPica
            // 
            this.dgvOdabranaPica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabranaPica.Location = new System.Drawing.Point(765, 58);
            this.dgvOdabranaPica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOdabranaPica.Name = "dgvOdabranaPica";
            this.dgvOdabranaPica.RowHeadersWidth = 51;
            this.dgvOdabranaPica.RowTemplate.Height = 24;
            this.dgvOdabranaPica.Size = new System.Drawing.Size(463, 340);
            this.dgvOdabranaPica.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(544, 58);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(193, 63);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj u nardžbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(544, 148);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(193, 63);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Pošalji narudžbu";
            this.btnPosalji.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Odabrana pića:";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(544, 243);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(193, 63);
            this.btnIzbrisi.TabIndex = 10;
            this.btnIzbrisi.Text = "Izbriši piće";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Location = new System.Drawing.Point(544, 335);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(193, 63);
            this.btnOdjaviSe.TabIndex = 11;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(25, 58);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.RowTemplate.Height = 24;
            this.dgvArtikli.Size = new System.Drawing.Size(463, 340);
            this.dgvArtikli.TabIndex = 5;
            // 
            // frmKorisnikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 454);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOdabranaPica);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label1);
            this.Name = "frmKorisnikPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeApp";
            this.Load += new System.EventHandler(this.frmKorisnikPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaPica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOdabranaPica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.DataGridView dgvArtikli;
    }
}