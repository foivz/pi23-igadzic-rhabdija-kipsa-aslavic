namespace CoffeeApp
{
    partial class frmKonobarPocetna
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
            this.btnPlacanjeNarudzbe = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlacanjeNarudzbe
            // 
            this.btnPlacanjeNarudzbe.Location = new System.Drawing.Point(146, 75);
            this.btnPlacanjeNarudzbe.Name = "btnPlacanjeNarudzbe";
            this.btnPlacanjeNarudzbe.Size = new System.Drawing.Size(115, 53);
            this.btnPlacanjeNarudzbe.TabIndex = 0;
            this.btnPlacanjeNarudzbe.Text = "Plaćanje narudžbi";
            this.btnPlacanjeNarudzbe.UseVisualStyleBackColor = true;
            this.btnPlacanjeNarudzbe.Click += new System.EventHandler(this.btnPlacanjeNarudzbe_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(146, 174);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(115, 53);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // frmKonobarPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 285);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnPlacanjeNarudzbe);
            this.Name = "frmKonobarPocetna";
            this.Text = "Konobar Početna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlacanjeNarudzbe;
        private System.Windows.Forms.Button btnOdjava;
    }
}