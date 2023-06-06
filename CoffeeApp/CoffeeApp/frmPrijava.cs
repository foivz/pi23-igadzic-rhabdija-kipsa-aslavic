using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        RepozitorijKorisnika repozitorij = new RepozitorijKorisnika(); 
        public static Korisnik ulogirani = new Korisnik();

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;
            if(txtbUsername.Text == "" || txtbPassword.Text == "")
            {
                MessageBox.Show("Polja ne mogu biti prazna");
            }
            txtbUsername.Clear();
            txtbPassword.Clear();
            repozitorij.ProvjeriPrijavu(username, password);
            Korisnik dohvaceniKorisnik = repozitorij.DohvatiKorisnika(username, password);
            ulogirani = dohvaceniKorisnik;
            UlogiraniKorisnik.ulogirani = dohvaceniKorisnik;
            if (dohvaceniKorisnik.Uloga == "Korisnik")
            {
                this.Hide();
                frmKorisnikPocetna forma = new frmKorisnikPocetna();
                forma.ShowDialog();
            }
            if(dohvaceniKorisnik.Uloga == "Admin")
            {
                this.Hide();
                frmAdminPocetna forma = new frmAdminPocetna();
                forma.ShowDialog();
            }
            if(dohvaceniKorisnik.Uloga == "Glavni konobar")
            {
                this.Hide();
                frmGlavniKonobarPocetna forma = new frmGlavniKonobarPocetna();
                forma.ShowDialog();
            }
            if(dohvaceniKorisnik.Uloga == "Konobar")
            {
                this.Hide();
                frmKonobarPocetna forma = new frmKonobarPocetna();
                forma.ShowDialog();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
