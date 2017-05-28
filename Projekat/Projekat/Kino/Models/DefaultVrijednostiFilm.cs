using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class DefaultVrijednostiFilm
    {
        public static void Initialize(KinoDbContext context)
        {
            if (!context.Filmovi.Any())
            {
                context.Filmovi.AddRange(
                new Film()
                {
                    filmId = 99,
                    zanr = "komedija",
                    naziv = "The Hangover",
                    trajanje = 100,
                    godina = 2009,
                    plot = "",
                    imdb = "http://www.imdb.com/title/tt1119646/",
                    Slika=null,
                }, new Film()
                {
                    filmId = 98,
                    zanr = "akcija",
                    naziv = "Die Hard",
                    trajanje = 105,
                    godina = 1988,
                    plot = "",
                    imdb = "http://www.imdb.com/title/tt0095016/",
                    Slika=null,
                }
                );
                context.SaveChanges();
            }
        }
    }
}

