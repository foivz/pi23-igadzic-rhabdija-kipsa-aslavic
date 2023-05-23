namespace CoffeeApp
{
    partial class frmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.CoffeeApp = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(53, 225);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(218, 58);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrirajSe.Location = new System.Drawing.Point(53, 315);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(218, 58);
            this.btnRegistrirajSe.TabIndex = 1;
            this.btnRegistrirajSe.Text = "Registriraj se";
            this.btnRegistrirajSe.UseVisualStyleBackColor = true;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            // 
            // CoffeeApp
            // 
            this.CoffeeApp.AutoSize = true;
            this.CoffeeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeApp.Location = new System.Drawing.Point(81, 19);
            this.CoffeeApp.Name = "CoffeeApp";
            this.CoffeeApp.Size = new System.Drawing.Size(122, 25);
            this.CoffeeApp.TabIndex = 2;
            this.CoffeeApp.Text = "CoffeeApp";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(77, 57);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 162);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 410);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.CoffeeApp);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Controls.Add(this.btnPrijava);
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeApp";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.Windows.Forms.Label CoffeeApp;
        private System.Windows.Forms.PictureBox logo;
    }
}

