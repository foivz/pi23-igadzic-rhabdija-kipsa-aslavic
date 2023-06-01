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
            using (var context = new PI2313_DBEntities13())
            {
                Artikli katalog_Pica = new  Artikli
                {
                    Naziv_Pica = naziv,
                    Cijena = cijena,
                    Kolicina = kolicina
                };
                context.Artiklis.Add(katalog_Pica);
                context.SaveChanges();
            }
        }
    }
}
