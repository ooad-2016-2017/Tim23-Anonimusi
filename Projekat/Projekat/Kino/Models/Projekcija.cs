using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    public class Projekcija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String projekcijaId { get; set; }
        public int idFilma { get; set; }
        public String naziv { get; set; }
        public String termini { get; set; }
        public int sala { get; set; }
        public DateTime prviDan { get; set; }
        public DateTime zadnjiDan { get; set; }

       
        public Projekcija()
        {
           // Film film;
          /*  using (var db = new KinoDbContext())
            {
                film = db.Filmovi.OrderBy(c => c.filmId == this.idFilma).ToList().FirstOrDefault();
            }
            naziv = film.naziv;*/
        }
    }
}
