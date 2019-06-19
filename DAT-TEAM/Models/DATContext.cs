using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATteam.Models
{
    public class DATContext : DbContext
    {
        public static DATContext instance;

        public static DATContext getInstance() {
            return instance;
        }

            public DATContext(DbContextOptions<DATContext> options) : base(options) => instance = this;

            public DbSet<Racun> Racun { get; set; }
            public DbSet<Menadzer> Menadzer { get; set; }
            public DbSet<Osoba> Osoba { get; set; }
            public DbSet<Radnik> Radnik { get; set; }
            public DbSet<Proizvod> Proizvod { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Racun>().ToTable("Racun");
                modelBuilder.Entity<Menadzer>().ToTable("Menadzer");
                modelBuilder.Entity<Osoba>().ToTable("Osoba");
                modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
                modelBuilder.Entity<Radnik>().ToTable("Radnik");
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            }
    }
   
}
