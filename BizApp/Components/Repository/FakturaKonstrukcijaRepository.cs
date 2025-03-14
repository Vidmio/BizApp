using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;
using Radzen;

namespace BizApp.Components.Repository
{
    public class FakturaKonstrukcijaRepository : GenericRepository<FakturaKonstrukcija>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;

        public FakturaKonstrukcijaRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<FakturaKonstrukcija>> Get()
        {
            using var db = await _context.CreateDbContextAsync();
            return await db.FakturaKonstrukcije.Include("Faktura").Include("Konstrukcija").ToListAsync();
        }


    }
}
