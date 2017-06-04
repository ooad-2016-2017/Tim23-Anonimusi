using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Projekat.Kino.Models;

namespace ProjekatMigrations
{
    [ContextType(typeof(KinoDbContext))]
    partial class KinoDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Projekat.Kino.Models.Film", b =>
                {
                    b.Property<int>("filmId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Slika")
                        .Annotation("Relational:ColumnType", "image");

                    b.Property<int>("godina");

                    b.Property<string>("imdb");

                    b.Property<string>("naziv");

                    b.Property<string>("plot");

                    b.Property<int>("trajanje");

                    b.Property<string>("zanr");

                    b.Key("filmId");
                });

            builder.Entity("Projekat.Kino.Models.Kino", b =>
                {
                    b.Property<int>("kinoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<int>("brojSala");

                    b.Property<string>("email");

                    b.Property<string>("grad");

                    b.Property<string>("telefon");

                    b.Key("kinoId");
                });

            builder.Entity("Projekat.Kino.Models.Projekcija", b =>
                {
                    b.Property<string>("projekcijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("idFilma");

                    b.Property<DateTime>("prviDan");

                    b.Property<int>("sala");

                    b.Property<DateTime>("zadnjiDan");

                    b.Key("projekcijaId");
                });
            builder.Entity("Projekat.Kino.Models.Uposleni", b =>
            {
                b.Property<int>("UposleniId")
                    .ValueGeneratedOnAdd();

                b.Property<string>("FourSqaureId");

                b.Property<string>("Ime");

                b.Property<string>("KorisnickoIme");

                b.Property<string>("MaticniBroj");

                b.Property<string>("Prezime");

                b.Property<string>("Sifra");

                b.Property<byte[]>("Slika")
                    .Annotation("Relational:ColumnType", "image");

                b.Key("UposleniId");
            });

        }
    }
}
