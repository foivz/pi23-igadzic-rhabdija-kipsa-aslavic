﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class frmRezervacijaStola : Form
    {
        public frmRezervacijaStola()
        {
            InitializeComponent();
        }

        private void frmRezervacijaStola_Load(object sender, EventArgs e)
        {
            btnRezerviraj.Enabled = true;
            btnPonisti.Enabled = false;
            DohvatiStolove();
            ProvjeraPostoceRezervacije();
            dtpVrijemeRezervacijeOd.Format= DateTimePickerFormat.Time;
            dtpVrijemeRezervacijeDo.Format = DateTimePickerFormat.Time;
            dtpVrijemeRezervacijeOd.ShowUpDown = true;
            dtpVrijemeRezervacijeDo.ShowUpDown = true;

        }

        private void ProvjeraPostoceRezervacije()
        {            
            foreach (DataGridViewRow row in dgvStolovi.Rows){
                if (row.Cells["ID_korisnika"].Value != null)
                {
                    if ((int)UlogiraniKorisnik.ulogirani.ID_Korisnika == (int)row.Cells["ID_korisnika"].Value)
                    {
                        btnRezerviraj.Enabled = false;
                        btnPonisti.Enabled = true;
                    }
                }
            }           
        }

        private void DohvatiStolove()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Stols
                            select p;

                dgvStolovi.DataSource = query.ToList();

                dgvStolovi.Columns["ID_stol"].Visible = false;
                dgvStolovi.Columns["ID_korisnika"].Visible = false;
                dgvStolovi.Columns["Korisnik"].Visible = false;
                dgvStolovi.Columns["datum_rezervacije"].Visible = false;
                dgvStolovi.Columns["vrijeme_rezervacije_od"].Visible = false;
                dgvStolovi.Columns["vrijeme_rezervacije_do"].Visible = false;

                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvStolovi.DataSource];
                currencyManager1.SuspendBinding();               

                foreach (DataGridViewRow row in dgvStolovi.Rows)
                {
                    if (row.Cells["status"].Value.ToString() != "slobodan")
                    {
                        row.Visible = false;
                    }
                }
                currencyManager1.ResumeBinding();
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Stol odabraniStol = dgvStolovi.CurrentRow.DataBoundItem as Stol;
                

                context.Stols.Attach(odabraniStol);

                odabraniStol.status = "rezerviran";
                odabraniStol.ID_korisnika = UlogiraniKorisnik.ulogirani.ID_Korisnika;
                odabraniStol.datum_rezervacije = dtpDatumRezervacije.Value;
                odabraniStol.vrijeme_rezervacije_od = dtpVrijemeRezervacijeOd.Value;
                odabraniStol.vrijeme_rezervacije_do = dtpVrijemeRezervacijeDo.Value;

                context.SaveChanges();
            }
            DohvatiStolove();
            ProvjeraPostoceRezervacije();
            
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            using (var context = new PI2313_DBEntities13())
            {
                foreach (DataGridViewRow row in dgvStolovi.Rows)
                {
                    if (row.Cells["ID_korisnika"].Value != null)
                    {
                        if ((int)UlogiraniKorisnik.ulogirani.ID_Korisnika == (int)row.Cells["ID_korisnika"].Value)
                        {
                            Stol odabraniStol = row.DataBoundItem as Stol;

                            context.Stols.Attach(odabraniStol);

                            odabraniStol.status = "slobodan";
                            odabraniStol.ID_korisnika = null;
                            odabraniStol.datum_rezervacije = null;
                            odabraniStol.vrijeme_rezervacije_od = null;
                            odabraniStol.vrijeme_rezervacije_do = null;

                            context.SaveChanges();
                        }
                    }
                }              
            }
            DohvatiStolove();
            btnRezerviraj.Enabled = true;
            btnPonisti.Enabled = false;
        }
    }
}
