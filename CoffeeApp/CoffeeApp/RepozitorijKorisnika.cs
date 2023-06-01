using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public class RepozitorijKorisnika
    {
        public bool ProvjeriPrijavu(string username, string passowrd)
        {
            using(var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Korisniks
                            where p.Username == username && p.Password == passowrd
                            select p;
                if (query.Any())
                {
                    MessageBox.Show("Uspješno se ulogirani");
                    return true;
                }
                else
                {
                    MessageBox.Show("Krivo korisničko ime ili lozinka");
                    return false;
                }
            }
        }

        public void DodajKorisnika(string ime, string prezime, string email, string username, string passowrd, string uloga, string smjena)
        {
            using(var context = new PI2313_DBEntities13())
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Username = username,
                    Password = passowrd,
                    Uloga = uloga,
                    Smjena = smjena
                };
                context.Korisniks.Add(korisnik);
                context.SaveChanges();
            }
        }

        public Korisnik DohvatiKorisnika(string username, string password)
        {
            Korisnik odabrani = new Korisnik();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using (var context = new PI2313_DBEntities13())
            {
                var query = from p in context.Korisniks
                            select p;
                listaKorisnika = query.ToList();
            }
            foreach (Korisnik item in listaKorisnika)
            {
                if (item.Password == password && username == item.Username)
                {
                    odabrani = item;
                    break;
                }
            }
            return odabrani;
        }
    }
}
