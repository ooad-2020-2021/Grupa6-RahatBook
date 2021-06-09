using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RahatBookAplikacija.Models;

namespace RahatBookApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SmjestajnaJedinica> SmjestajnaJedinica { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        public DbSet<Login> Login { get; set; }

        public DbSet<Lokacija> Lokacija { get; set; }

        public DbSet<Popust> Popust { get; set; }

        public DbSet<Uplata> Uplata { get; set; }

        public DbSet<Gost> Gost { get; set; }

        public DbSet<KontaktInfo> KontaktInfo { get; set; }

        public DbSet<Recenzija> Recenzija { get; set; }

        public DbSet<Upit> Upit { get; set; }

        public DbSet<SJSobe> SJSobe { get; set; }

        public DbSet<VrstaSobe> VrstaSobe { get; set; }

        public DbSet<Administrator> Administrator { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<SmjestajnaJedinica>().ToTable("SmjestajnaJedinica");
            mb.Entity<Rezervacija>().ToTable("Rezervacija");
            mb.Entity<RegistrovaniKorisnik>().ToTable("RegistrovaniKorisnik");
            mb.Entity<Login>().ToTable("Login");
            mb.Entity<Lokacija>().ToTable("Lokacija");
            mb.Entity<Popust>().ToTable("Popust");
            mb.Entity<Uplata>().ToTable("Uplata");
            mb.Entity<Gost>().ToTable("Gost");
            mb.Entity<KontaktInfo>().ToTable("KontaktInfo");
            mb.Entity<Recenzija>().ToTable("Recenzija");
            mb.Entity<Upit>().ToTable("Upit");
            mb.Entity<SJSobe>().ToTable("SJSobe");
            mb.Entity<VrstaSobe>().ToTable("VrstaSobe");
            base.OnModelCreating(mb);
        }
    }
}
