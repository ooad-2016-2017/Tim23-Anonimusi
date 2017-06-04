using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProjekatMigrations
{
    public partial class InitialMigtation : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Film",
                columns: table => new
                {
                    filmId = table.Column(type: "INTEGER", nullable: false),
                      // .Annotation("Sqlite:Autoincrement", true),
                    Slika = table.Column(type: "image", nullable: true),
                    godina = table.Column(type: "INTEGER", nullable: false),
                    imdb = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    plot = table.Column(type: "TEXT", nullable: true),
                    trajanje = table.Column(type: "INTEGER", nullable: false),
                    zanr = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.filmId);
                });
            migration.CreateTable(
                name: "Kino",
                columns: table => new
                {
                    kinoId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojSala = table.Column(type: "INTEGER", nullable: false),
                    email = table.Column(type: "TEXT", nullable: true),
                    grad = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kino", x => x.kinoId);
                });
            migration.CreateTable(
                name: "Projekcija",
                columns: table => new
                {
                    projekcijaId = table.Column(type: "TEXT", nullable: false),
                    idFilma = table.Column(type: "INTEGER", nullable: false),
                    prviDan = table.Column(type: "TEXT", nullable: false),
                    sala = table.Column(type: "INTEGER", nullable: false),
                    zadnjiDan = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcija", x => x.projekcijaId);
                });
            migration.CreateTable(
               name: "Uposleni",
               columns: table => new
               {
                   UposleniId = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation(SQLite:Autoincrement",true),
                    FourSqaureId = table.Column(type: "TEXT", nullable: true),
                   Ime = table.Column(type: "TEXT", nullable: true),
                   KorisnickoIme = table.Column(type: "TEXT", nullable: true),
                   MaticniBroj = table.Column(type: "TEXT", nullable: true),
                   Prezime = table.Column(type: "TEXT", nullable: true),
                   Sifra = table.Column(type: "TEXT", nullable: true),
                   Slika = table.Column(type: "image", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Uposleni", x => x.UposleniId);
               });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Film");
            migration.DropTable("Kino");
            migration.DropTable("Projekcija");
        }
    }
}
