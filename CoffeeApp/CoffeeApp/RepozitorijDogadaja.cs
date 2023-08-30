using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class RepozitorijDogadaja
    {
        public void DodajDogadaj(string naziv, string opis, DateTime datum,  DateTime vrijemePocetka, double cijena, int idAdmn)
        {
            using(var context = new PI2313_DBEntities13())
            {
                Dogadaj dogadaji = new Dogadaj()
                {
                    Naziv = naziv,
                    Opis = opis,
                    Datum = datum,
                    Vrijeme_pocetka = vrijemePocetka.TimeOfDay,
                    Cijena = cijena,
                    ID_Administratora = idAdmn
                };

                context.Dogadajs.Add(dogadaji);
                context.SaveChanges();
            }
        }
    }
}
