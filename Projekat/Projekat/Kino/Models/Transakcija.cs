using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class Transakcija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private string sifraRezervacije;
        private int brojKarata;
        private int cijena;

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
        public string Sifrarezervacije
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
        public int BrojKarata
        {
            get
            {
                return brojKarata;
            }

            set
            {
                brojKarata = value;
            }
        }
        public int Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }
        
    }
}
