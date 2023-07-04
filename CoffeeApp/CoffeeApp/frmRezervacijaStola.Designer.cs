namespace CoffeeApp
{
    partial class frmRezervacijaStola
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
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dtpDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijemeRezervacijeOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijemeRezervacijeDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(12, 12);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.RowHeadersWidth = 51;
            this.dgvStolovi.RowTemplate.Height = 24;
            this.dgvStolovi.Size = new System.Drawing.Size(658, 356);
            this.dgvStolovi.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(275, 388);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(119, 59);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj stol";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(410, 388);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(140, 59);
            this.btnPonisti.TabIndex = 2;
            this.btnPonisti.Text = "Poništi postojeću rezervaciju";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(573, 388);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(97, 59);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dtpDatumRezervacije
            // 
            this.dtpDatumRezervacije.Location = new System.Drawing.Point(12, 388);
            this.dtpDatumRezervacije.Name = "dtpDatumRezervacije";
            this.dtpDatumRezervacije.Size = new System.Drawing.Size(242, 22);
            this.dtpDatumRezervacije.TabIndex = 4;
            // 
            // dtpVrijemeRezervacijeOd
            // 
            this.dtpVrijemeRezervacijeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeRezervacijeOd.Location = new System.Drawing.Point(12, 460);
            this.dtpVrijemeRezervacijeOd.Name = "dtpVrijemeRezervacijeOd";
            this.dtpVrijemeRezervacijeOd.Size = new System.Drawing.Size(104, 22);
            this.dtpVrijemeRezervacijeOd.TabIndex = 5;
            // 
            // dtpVrijemeRezervacijeDo
            // 
            this.dtpVrijemeRezervacijeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeRezervacijeDo.Location = new System.Drawing.Point(150, 460);
            this.dtpVrijemeRezervacijeDo.Name = "dtpVrijemeRezervacijeDo";
            this.dtpVrijemeRezervacijeDo.Size = new System.Drawing.Size(104, 22);
            this.dtpVrijemeRezervacijeDo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vrijeme Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vrijeme Do:";
            // 
            // frmRezervacijaStola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpVrijemeRezervacijeDo);
            this.Controls.Add(this.dtpVrijemeRezervacijeOd);
            this.Controls.Add(this.dtpDatumRezervacije);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.dgvStolovi);
            this.Name = "frmRezervacijaStola";
            this.Text = "Rezervacija Stola";
            this.Load += new System.EventHandler(this.frmRezervacijaStola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DateTimePicker dtpDatumRezervacije;
        private System.Windows.Forms.DateTimePicker dtpVrijemeRezervacijeOd;
        private System.Windows.Forms.DateTimePicker dtpVrijemeRezervacijeDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}