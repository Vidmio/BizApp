using Microsoft.EntityFrameworkCore;
using Radzen.Blazor.Rendering;

namespace BizApp.Components.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<GrupaProizvod> GrupaProizvoda { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Faktura> Fakture { get; set; }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Konstrukcija> Konstrukcije { get; set; }

        public DbSet<FakturaKonstrukcija> FakturaKonstrukcije { get; set; }

    }
}
