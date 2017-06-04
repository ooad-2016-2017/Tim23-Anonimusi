using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class DefaultVrijednostiProjekcija
    {
        public static void Initialize(KinoDbContext context)
        {
            if (!context.Projekcije.Any())
            {
                context.Projekcije.AddRange(
                new Projekcija()
                {
                    projekcijaId = "TH99",
                    idFilma = 99,
                    sala = 1,
                    prviDan = DateTime.Today.Date,
                    zadnjiDan = DateTime.Today.AddDays(14).Date,
                    termini = "12:00, 17:00, 20:00",
                    naziv = "The Hangover",
                }, new Projekcija()
                {
                    projekcijaId = "DH98",
                    idFilma = 98,
                    sala = 2,
                    prviDan = DateTime.Today.Date,
                    zadnjiDan = DateTime.Today.AddDays(14).Date,
                    termini = "18:00, 21:00, 22:30",
                    naziv = "Die Hard",
                }
                );
                context.SaveChanges();
            }
        }
    }
}

