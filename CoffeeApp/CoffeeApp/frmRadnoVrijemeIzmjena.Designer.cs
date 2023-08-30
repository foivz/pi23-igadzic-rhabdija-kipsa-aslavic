namespace CoffeeApp
{
    partial class frmRadnoVrijemeIzmjena
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijemeOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijemeDo = new System.Windows.Forms.DateTimePicker();
            this.lblOdabraniDan = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabrani dan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrijeme od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrijeme do:";
            // 
            // dtpVrijemeOd
            // 
            this.dtpVrijemeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeOd.Location = new System.Drawing.Point(16, 86);
            this.dtpVrijemeOd.Name = "dtpVrijemeOd";
            this.dtpVrijemeOd.Size = new System.Drawing.Size(81, 20);
            this.dtpVrijemeOd.TabIndex = 3;
            // 
            // dtpVrijemeDo
            // 
            this.dtpVrijemeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeDo.Location = new System.Drawing.Point(167, 86);
            this.dtpVrijemeDo.Name = "dtpVrijemeDo";
            this.dtpVrijemeDo.Size = new System.Drawing.Size(85, 20);
            this.dtpVrijemeDo.TabIndex = 4;
            // 
            // lblOdabraniDan
            // 
            this.lblOdabraniDan.AutoSize = true;
            this.lblOdabraniDan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblOdabraniDan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOdabraniDan.Location = new System.Drawing.Point(13, 40);
            this.lblOdabraniDan.Name = "lblOdabraniDan";
            this.lblOdabraniDan.Size = new System.Drawing.Size(30, 13);
            this.lblOdabraniDan.TabIndex = 5;
            this.lblOdabraniDan.Text = "DAN";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(16, 152);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 40);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(167, 152);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(75, 40);
            this.btnSpremiPromjene.TabIndex = 7;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // frmRadnoVrijemeIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 204);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblOdabraniDan);
            this.Controls.Add(this.dtpVrijemeDo);
            this.Controls.Add(this.dtpVrijemeOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRadnoVrijemeIzmjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena Radnog vremena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijemeOd;
        private System.Windows.Forms.DateTimePicker dtpVrijemeDo;
        private System.Windows.Forms.Label lblOdabraniDan;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremiPromjene;
    }
}