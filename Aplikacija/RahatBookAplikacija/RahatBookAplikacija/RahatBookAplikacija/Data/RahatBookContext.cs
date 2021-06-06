using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RahatBookAplikacija.Models;

namespace RahatBookAplikacija.Data
{
    public class RahatBookContext : DbContext
    {
        public RahatBookContext (DbContextOptions<RahatBookContext> options)
            : base(options)
        {
        }

        public DbSet<RahatBookAplikacija.Models.SmjestajnaJedinica> SmjestajnaJedinica { get; set; }

        public DbSet<RahatBookAplikacija.Models.Rezervacija> Rezervacija { get; set; }

        public DbSet<RahatBookAplikacija.Models.RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }

        public DbSet<RahatBookAplikacija.Models.Administrator> Administrator { get; set; }

        public DbSet<RahatBookAplikacija.Models.Login> Login { get; set; }
    }
}
