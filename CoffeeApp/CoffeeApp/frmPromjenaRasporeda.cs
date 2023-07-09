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
    public partial class frmPromjenaRasporeda : Form
    {
        public frmPromjenaRasporeda(Korisnik selektiraniKorisnik, PI2313_DBEntities13 context1)
        {
            InitializeComponent();
            this.selektirani = selektiraniKorisnik;
            this.context = context1;
        }

        public Korisnik selektirani;
        public PI2313_DBEntities13 context;

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //using (var context = new PI2313_DBEntities13())
            {
                string ime = txtbIme.Text.ToString();
                string prezime = txtbPrezime.Text.ToString();
                int smjena = cmbSmjena.SelectedIndex + 1;

                context.Korisniks.Attach(selektirani);

                selektirani.Ime = ime;
                selektirani.Prezime = prezime;
                selektirani.Smjena = smjena;
                
                context.SaveChanges();
            }
            Close();
        }

        private void frmPromjenaRasporeda_Load(object sender, EventArgs e)
        {
            txtbIme.ReadOnly = true;
            txtbPrezime.ReadOnly = true;
            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;

            popuniCmbSmjene();

            cmbSmjena.SelectedIndex = selektirani.Smjena - 1;

        }

        private void popuniCmbSmjene()
        {
            List<Smjena> smjene;

            //using (var context = new PI2313_DBEntities13())
            {
                smjene = context.Smjenas.ToList();
            }

            cmbSmjena.DataSource = smjene;

            for (int i = 1; i < cmbSmjena.Items.Count; i++)
            {
                if ((cmbSmjena.Items[i] as Smjena).ID_smjena == selektirani.Smjena)
                {
                    cmbSmjena.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
