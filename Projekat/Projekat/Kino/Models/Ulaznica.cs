using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class Ulaznica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private string sifra;
        private bool popust;
        private string projekcija;
        private string sala;
        private DateTime pocetakFilma;
        private DateTime krajFilma;
        private string sifraRezervacije;
        private bool iskoristena = false;

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
        public string Sifra
        {
            get
            {
                return sifra;
            }

            set
            {
                sifra = value;
            }
        }
        public bool Popust
        {
            get
            {
                return popust;
            }

            set
            {
                popust = value;
            }
        }
        public string Projekcija
        {
            get
            {
                return projekcija;
            }

            set
            {
                projekcija = value;
            }
        }
        public string Sala
        {
            get
            {
                return sala;
            }

            set
            {
                sala = value;
            }
        }
        public DateTime PocetakFilma
        {
            get
            {
                return pocetakFilma;
            }

            set
            {
                pocetakFilma = value;
            }
        }
        public DateTime KrajFilma
        {
            get
            {
                return krajFilma;
            }

            set
            {
                krajFilma = value;
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
        public bool Iskoristena
        {
            get
            {
                return iskoristena;
            }
            set
            {
                iskoristena = value;
            }

        }
    }
}
