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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava frmPrijava = new frmPrijava();
            frmPrijava.ShowDialog();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            frmRegistracija frmRegistracija = new frmRegistracija();
            frmRegistracija.ShowDialog();
        }
    }
}
