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
    public partial class frmKorisnikPocetna : Form
    {
        public frmKorisnikPocetna()
        {
            InitializeComponent();
        }

        public frmKorisnikPocetna(Korisnik dohvaceniKorisnik)
        {
            DohvaceniKorisnik = dohvaceniKorisnik;
        }

        public Korisnik DohvaceniKorisnik { get; }
    }
}
