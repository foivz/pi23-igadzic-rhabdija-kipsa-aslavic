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
        }
    }
}
