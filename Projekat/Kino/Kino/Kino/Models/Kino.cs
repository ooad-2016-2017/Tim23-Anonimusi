using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Kino.Models
{
    class Kino
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int idKina { get; set; }
        private String grad { get; set; }
        private String adresa { get; set; }
        private String email { get; set; }
        private String brojTelefona { get; set; }
        private int brojSala { get; set; }
    }
}
