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
