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
    public partial class frmAdminPocetna : Form
    {
        public frmAdminPocetna()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            frmUpravljanjeKorisnicima forma = new frmUpravljanjeKorisnicima();
            forma.ShowDialog();
        }

        private void btnPregeldZaliha_Click(object sender, EventArgs e)
        {
            frmPregledZaliha form = new frmPregledZaliha();
            form.ShowDialog();
        }
    }
}
