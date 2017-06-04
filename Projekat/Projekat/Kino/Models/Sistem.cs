using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Projekat.Kino.Models
{
    class Sistem
    {
        String adminName { get; set; }
        String adminLozinka { get; set; }
        public List<Kino> kina { get; set; }
        public List<Film> filmovi { get; set; }
        public List<Projekcija> projekcije { get; set; }
        public List<Uposleni> uposleni { get; set; }
        public List<Ulaznica> ulaznice { get; set; }
        public List<Clan> clanovi { get; set; }

        public Sistem()
        {
            adminName = "cineramadmin";
            adminLozinka = "cinerama";
        }
        public static Boolean provjeraKorisnika(String ime, String lozinka)
        {
            Sistem s = new Sistem();
            if (s.adminLozinka.Equals(lozinka) && s.adminName.Equals(ime)) return true;
            return false;
        }
    }
}
