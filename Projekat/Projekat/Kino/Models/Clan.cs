using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class Clan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private string ime;
        private string prezime;
        private string maticniBroj;
        private string grad;
        private string sifraKartice;

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
        public string MaticniBroj
        {
            get
            {
                return maticniBroj;
            }

            set
            {
                maticniBroj = value;
            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }

            set
            {
                grad = value;
            }
        }
        public string SifraKartice
        {
            get
            {
                return sifraKartice;
            }

            set
            {
                sifraKartice = value;
            }
        }
    }
}
