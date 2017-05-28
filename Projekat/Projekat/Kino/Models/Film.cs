using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    public class Film
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int filmId { get; set; }
        public String zanr { get; set; }
        public String naziv { get; set; }
        public int trajanje { get; set; }
        public int godina  { get; set; }
        public String plot { get; set; }
        public String imdb { get; set; }
        public byte[] Slika { get; set; }
    }
}
