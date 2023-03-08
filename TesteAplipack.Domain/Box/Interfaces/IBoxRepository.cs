using TesteAplipack.Domain.Box.Models;

namespace TesteAplipack.Domain.Box.Interfaces
{
    public interface IBoxRepository
    {
        Task CreateAsync(BoxModel box);
    }
}
