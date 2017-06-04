using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProjekatMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                    //    .Annotation("Sqlite:Autoincrement", true),
                    Grad = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    MaticniBroj = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    SifraKartice = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.Id);
                });
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
               //         .Annotation("Sqlite:Autoincrement", true),
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
                    naziv = table.Column(type: "TEXT", nullable: true),
                    prviDan = table.Column(type: "TEXT", nullable: false),
                    sala = table.Column(type: "INTEGER", nullable: false),
                    termini = table.Column(type: "TEXT", nullable: true),
                    zadnjiDan = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcija", x => x.projekcijaId);
                });
            migration.CreateTable(
                name: "Transakcija",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                //        .Annotation("Sqlite:Autoincrement", true),
                    BrojKarata = table.Column(type: "INTEGER", nullable: false),
                    Cijena = table.Column(type: "INTEGER", nullable: false),
                    Sifrarezervacije = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcija", x => x.Id);
                });
            migration.CreateTable(
                name: "Ulaznica",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                     //   .Annotation("Sqlite:Autoincrement", true),
                    Iskoristena = table.Column(type: "INTEGER", nullable: false),
                    KrajFilma = table.Column(type: "TEXT", nullable: false),
                    PocetakFilma = table.Column(type: "TEXT", nullable: false),
                    Popust = table.Column(type: "INTEGER", nullable: false),
                    Projekcija = table.Column(type: "TEXT", nullable: true),
                    Sala = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    SifraRezervacije = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulaznica", x => x.Id);
                });
            migration.CreateTable(
                name: "Uposleni",
                columns: table => new
                {
                    UposleniId = table.Column(type: "INTEGER", nullable: false),
                     //   .Annotation("Sqlite:Autoincrement", true),
                    FourSqaureId = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    KorisnickoIme = table.Column(type: "TEXT", nullable: true),
                    MaticniBroj = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposleni", x => x.UposleniId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Clan");
            migration.DropTable("Film");
            migration.DropTable("Kino");
            migration.DropTable("Projekcija");
            migration.DropTable("Transakcija");
            migration.DropTable("Ulaznica");
            migration.DropTable("Uposleni");
        }
    }
}
