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
                    projekcijaId="TH99",
                    idFilma = 99,
                    sala=1,
                    prviDan =  DateTime.Today,
                    zadnjiDan= DateTime.Today.AddDays(14),
                }, new Projekcija()
                {
                    projekcijaId = "DH98",
                    idFilma = 98,
                    sala = 2,
                    prviDan = DateTime.Today,
                    zadnjiDan = DateTime.Today.AddDays(14),
                }
                );
                context.SaveChanges();
            }
        }
    }
}

