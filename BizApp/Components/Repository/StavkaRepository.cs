using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace BizApp.Components.Repository
{
    public class StavkaRepository : GenericRepository<Stavka>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;

        public StavkaRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Stavka>> Get()
        {
            using var db = await _context.CreateDbContextAsync();
            return await db.Stavke.Include("Proizvod").ToListAsync();
        }
    }
}
