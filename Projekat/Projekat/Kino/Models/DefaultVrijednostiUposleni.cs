using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Models
{
    class DefaultVrijednostiUposleni
    {
        public static void Initialize(KinoDbContext context)
        {
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                    new Uposleni()
                    {
                        Ime = "Melika",
                        Prezime = "Sisic",

                        MaticniBroj = "1710996784512",
                        KorisnickoIme = "msisic1",
                        Sifra = "12345"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                    new Uposleni()
                    {
                        Ime = "Lejla",
                        Prezime = "Aksamovic",

                        MaticniBroj = "1008997845123",
                        KorisnickoIme = "laksamovic1",
                        Sifra = "1256"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                    new Uposleni()
                    {
                        Ime = "Jasmin",
                        Prezime = "Aksamovic",

                        MaticniBroj = "0504995698532",
                        KorisnickoIme = "jaksamovic1",
                        Sifra = "1356"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                    new Uposleni()
                    {
                        Ime = "Maid",
                        Prezime = "Osmanagic",

                        MaticniBroj = "1112998745123",
                        KorisnickoIme = "mosmanagic1",
                        Sifra = "1452"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                    new Uposleni()
                    {
                        Ime = "Dino",
                        Prezime = "Karic",

                        MaticniBroj = "051291478512",
                        KorisnickoIme = "dkaric1",
                        Sifra = "4521"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
