using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class eKupac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private string ime;
        private string prezime;
        private string email;
        private string brojKartice;
        private string sifraRezervacije;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string BrojKartice
        {
            get
            {
                return brojKartice;
            }

            set
            {
                brojKartice = value;
            }
        }
        public string SifraRezervacije
        {
            get
            {
                return sifraRezervacije;
            }

            set
            {
                sifraRezervacije = value;
            }
        }
    }
}
