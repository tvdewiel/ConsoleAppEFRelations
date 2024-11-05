using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class GeoWikiContext : DbContext
    {
        private string connectionString;

        public GeoWikiContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<CountryEF> Country { get; set; }
        public DbSet<ContinentEF> Continent { get; set; }
        public DbSet<CityEF> City { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString)
                .LogTo(Console.WriteLine,LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryEF>()
                .HasMany(x => x.Continents)
                .WithMany(x => x.Countries)
                .UsingEntity("ContinentCountry");
            modelBuilder.Entity<ContinentNameEF>().ToTable("ContinentName");
            modelBuilder.Entity<CountryNameEF>().ToTable("CountryName");
            modelBuilder.Entity<CityNameEF>().ToTable("CityName");
            modelBuilder.Entity<CapitalEF>().ToTable("Capital");

            //modelBuilder.Entity<CityEF>()
            //    .HasOne(x => x.CountryCity)
            //    .WithMany(x => x.Cities)
            //    .OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<CityEF>()
            //    .HasOne(x => x.CapitalCity)
            //    .WithMany(x => x.Capitals)
            //    .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CapitalEF>()
                .HasKey(x => new { x.CountryId, x.CityId });
            modelBuilder.Entity<CapitalEF>()
                .HasOne(x => x.Country)
                .WithMany(x=>x.Capitals)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CapitalEF>()
                .HasOne(x => x.City)
                .WithOne();

            modelBuilder.Entity<CountryEF>()
                .HasMany(x => x.Rivers)
                .WithMany(x => x.Countries)
                .UsingEntity<CountryRiverEF>(
                    j=>j.HasOne(x=>x.River)
                        .WithMany(x=>x.CountryRivers)
                        .HasForeignKey(x=>x.RiverId),
                    j=>j
                        .HasOne(x=>x.Country)
                        .WithMany()
                        .HasForeignKey(x=>x.CountryId),
                    j =>
                    {
                        j.Property(x => x.LengthInCountry);
                        j.HasKey(x=>new {x.CountryId,x.RiverId});
                    }

                );

        }
    }
}
