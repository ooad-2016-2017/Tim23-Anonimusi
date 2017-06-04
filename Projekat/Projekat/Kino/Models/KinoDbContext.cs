using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Projekat.Kino.Models
{
    class KinoDbContext : DbContext
    {
        public DbSet<Kino> Kina { get; set; }
        public DbSet<Film> Filmovi { get; set; }
        public DbSet<Projekcija> Projekcije { get; set; }
        public DbSet<Uposleni> Uposlenici { get; set; }
        public DbSet<Clan> Clanovi { get; set; }
        public DbSet<Ulaznica> Ulaznice { get; set; }
        public DbSet<Transakcija> Transakcije { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Ooadbaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Film>().Property(p => p.Slika).HasColumnType("image");
        }
    }
    
}
