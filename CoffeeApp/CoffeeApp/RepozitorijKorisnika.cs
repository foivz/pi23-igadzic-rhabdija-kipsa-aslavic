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
            using(var context = new PI2313_DBEntities7())
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

        public void DodajKorisnika(string ime, string prezime, string email, string username, string passowrd, string uloga)
        {
            using(var context = new PI2313_DBEntities7())
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Username = username,
                    Password = passowrd,
                    Uloga = uloga
                };
                context.Korisniks.Add(korisnik);
                context.SaveChanges();
            }
        }
    }
}
