using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class DefaultVrijednostiKino
    {
        public static void Initialize(KinoDbContext context)
        {
            
            if (!context.Kina.Any())
            {
                context.Kina.AddRange(
                new Kino()
                {
                    kinoId = 10,
                    grad = "Sarajevo",
                    adresa="Porodice Ribar 43",
                    email= "cinerama.10@gmail.com",
                    telefon="033/210-403",
                    brojSala=7,
                }, new Kino()
                {
                    kinoId = 11,
                    grad = "Mostar",
                    adresa = "Ulica Marsala Tita",
                    email = "cinerama.11@gmail.com",
                    telefon = "036/310-444",
                    brojSala = 7,
                }
                );
                context.SaveChanges();
            }
            
        }
    }
}

