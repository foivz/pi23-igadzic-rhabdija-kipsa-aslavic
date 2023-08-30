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
    public partial class frmPrikazRadnogVremena : Form
    {
        public frmPrikazRadnogVremena()
        {
            InitializeComponent();
        }

        private void btnURedu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrikazRadnogVremena_Load(object sender, EventArgs e)
        {
            DohvatiRadnoVrijeme();
        }

        public void DohvatiRadnoVrijeme()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from r in context.Radno_Vrijeme
                            select new
                            {
                                Dan = r.Dan_Tjedna,
                                Od = r.Vrijeme_Od,
                                Do = r.Vrijeme_Do
                            };

                dgvRadnoVrijemePrikaz.DataSource = query.ToList();
            }
        }

    }
}
