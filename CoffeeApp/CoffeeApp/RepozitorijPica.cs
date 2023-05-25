using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class RepozitorijPica
    {
        public void DodajPice(string naziv, double cijena, string kolicina)
        {
            using (var context = new PI2313_DBEntities8())
            {
                Katalog_Pica katalog_Pica = new Katalog_Pica
                {
                    Naziv_Pica = naziv,
                    Cijena = cijena,
                    Kolicina = kolicina
                };
                context.Katalog_Pica.Add(katalog_Pica);
                context.SaveChanges();
            }
        }
    }
}
