using TesteAplipack.Domain.Box.Interfaces;
using TesteAplipack.Domain.Box.Models;
using TesteAplipack.Host.Context;

namespace TesteAplipack.Infra.Data.Repositories
{
    public class BoxRepository : IBoxRepository
    {
        private readonly ApiDbContext _context;
        public BoxRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(BoxModel box)
        {
            _context.Boxes.Add(box);
            await _context.SaveChangesAsync();
        }
    }
}
