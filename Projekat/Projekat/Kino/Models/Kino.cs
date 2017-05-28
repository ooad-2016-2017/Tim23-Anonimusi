using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    public class Kino
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kinoId { get; set; }
        public String grad { get; set; }
        public String adresa { get; set; }
        public String email { get; set; }
        public String telefon { get; set; }
        public int brojSala { get; set; }
    }
}
