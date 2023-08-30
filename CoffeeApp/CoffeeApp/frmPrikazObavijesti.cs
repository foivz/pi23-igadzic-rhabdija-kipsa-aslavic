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
    public partial class frmPrikazObavijesti : Form
    {
        public frmPrikazObavijesti()
        {
            InitializeComponent();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrikazObavijesti_Load(object sender, EventArgs e)
        {
            DohvatiObavijesti();
        }

        public void DohvatiObavijesti()
        {
            using (var context = new PI2313_DBEntities13())
            {
                var query = from o in context.Obavijestis
                            select new
                            {
                                OBAVIJEST = o.Naslov,
                                OPIS = o.Opis,
                                DATUM = o.Datum
                            };


                dgvPrikazObavijesti.DataSource = query.ToList();
            }
        }
    }
}
