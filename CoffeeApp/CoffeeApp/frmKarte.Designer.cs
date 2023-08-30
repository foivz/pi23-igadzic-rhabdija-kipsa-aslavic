namespace CoffeeApp
{
    partial class frmKarte
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
            this.dgvDogadaji = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvKarte = new System.Windows.Forms.DataGridView();
            this.btnKupiKartu = new System.Windows.Forms.Button();
            this.btnPoništi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogadaji
            // 
            this.dgvDogadaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadaji.Location = new System.Drawing.Point(125, 46);
            this.dgvDogadaji.Name = "dgvDogadaji";
            this.dgvDogadaji.Size = new System.Drawing.Size(622, 271);
            this.dgvDogadaji.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 562);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 56);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak na početnu";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvKarte
            // 
            this.dgvKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarte.Location = new System.Drawing.Point(125, 382);
            this.dgvKarte.Name = "dgvKarte";
            this.dgvKarte.Size = new System.Drawing.Size(622, 236);
            this.dgvKarte.TabIndex = 2;
            // 
            // btnKupiKartu
            // 
            this.btnKupiKartu.Location = new System.Drawing.Point(753, 145);
            this.btnKupiKartu.Name = "btnKupiKartu";
            this.btnKupiKartu.Size = new System.Drawing.Size(93, 79);
            this.btnKupiKartu.TabIndex = 3;
            this.btnKupiKartu.Text = "Kupi Kartu";
            this.btnKupiKartu.UseVisualStyleBackColor = true;
            this.btnKupiKartu.Click += new System.EventHandler(this.btnKupiKartu_Click);
            // 
            // btnPoništi
            // 
            this.btnPoništi.Location = new System.Drawing.Point(753, 464);
            this.btnPoništi.Name = "btnPoništi";
            this.btnPoništi.Size = new System.Drawing.Size(93, 79);
            this.btnPoništi.TabIndex = 4;
            this.btnPoništi.Text = "Poništi kartu";
            this.btnPoništi.UseVisualStyleBackColor = true;
            this.btnPoništi.Click += new System.EventHandler(this.btnPoništi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Popis događaja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moje karte:";
            // 
            // frmKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoništi);
            this.Controls.Add(this.btnKupiKartu);
            this.Controls.Add(this.dgvKarte);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvDogadaji);
            this.Name = "frmKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupovina karata";
            this.Load += new System.EventHandler(this.frmKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadaji;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvKarte;
        private System.Windows.Forms.Button btnKupiKartu;
        private System.Windows.Forms.Button btnPoništi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}