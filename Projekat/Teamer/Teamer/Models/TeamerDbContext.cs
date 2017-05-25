using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Teamer.Models
{
    class TeamerDbContext : DbContext
    {
        public DbSet<Menadzer> Menadzeri { get; set; }
        public DbSet<Trener> Treneri { get; set; }
        public DbSet<Igrac> Igraci { get; set; }
        public DbSet<Dogadjaj> Dogadjaji { get; set; }
        public DbSet<Izvjestaj> Izvjestaji { get; set; }
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<TipDogadjaja> TipoviDogadjaja { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Teamerbaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
