using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace BizApp.Components.Repository
{
    public class LagerRepository : GenericRepository<Lager>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;

        public LagerRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Lager>> Get()
        {
            using var db = await _context.CreateDbContextAsync();
            //return await db.Lageri.Include("Proizvod").ToListAsync();
            return await db.Lageri.Include(P =>P.Proizvod).ThenInclude(Pa => Pa.GrupaProizvod).ToListAsync();
        }
    }
}
