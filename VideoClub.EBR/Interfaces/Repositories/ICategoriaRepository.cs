using VideoClub.Entities.Entities;
using VideoClub.Etities.Interfaces.Repositories;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepositoroGenerico<Categoria>
    {
        Task<Categoria> GetById(int categoriaId);

        Task<List<Categoria>> GetAllCategorias();
    }
}
