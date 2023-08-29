using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class RepozitorijObavijesti
    {
        public void DodajObavijest(string naslov, string opis, DateTime datum, int korisnik)
        {
            using (var context = new PI2313_DBEntities13())
            {
                Obavijesti obavijesti = new Obavijesti
                {
                    Naslov = naslov,
                    Datum = datum,
                    Opis = opis,
                    ID_Korisnika = korisnik
                };
                context.Obavijestis.Add(obavijesti);
                context.SaveChanges();
            }
        }

    }
}
