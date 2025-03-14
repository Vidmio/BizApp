using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace BizApp.Components.Repository
{
    public class ProizvodRepository : GenericRepository<Proizvod>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;

        public ProizvodRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Proizvod>> Get()
        {
            using var db = await _context.CreateDbContextAsync();
            return await db.Proizvodi.Include("GrupaProizvod").ToListAsync();
        }
    }
}
