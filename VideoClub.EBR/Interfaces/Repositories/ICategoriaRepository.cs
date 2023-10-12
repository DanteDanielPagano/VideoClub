using VideoClub.Entities.Entities;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface ICategoriaRepository : IUnitOfWork
    {
        Task<Categoria> GetById(int categoriaId);
        Task Create(Categoria categoria);
        Task Update(Categoria categoria);
        Task Delete(int categoriaId);
        Task<List<Categoria>> GetAllCategorias();
    }
}
