using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class Uposleni
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UposleniId { get; set; }
        public string FourSqaureId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public string MaticniBroj { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
    }
}
