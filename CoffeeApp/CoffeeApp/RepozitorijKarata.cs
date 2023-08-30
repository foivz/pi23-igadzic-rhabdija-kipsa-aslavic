using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class RepozitorijKarata
    {
        public void DodajKartu(int dogadajId, int korisnikId)
        {
            using(var context = new PI2313_DBEntities13())
            {
                Karta karta = new Karta()
                {
                    ID_Dogadaja = dogadajId,
                    ID_Korisnika = korisnikId,
                };
                context.Kartas.Add(karta);
                context.SaveChanges();
            }
        }
    }
}
