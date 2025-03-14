using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;
using Radzen.Blazor.Rendering;

namespace BizApp.Components.Repository
{
    public class FakturaRepository : GenericRepository<Faktura>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;

        public FakturaRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Faktura>> Get()
        {
            using var db = await _context.CreateDbContextAsync();
            return await db.Fakture.Include("Klijent").ToListAsync();
        }
    }
}
