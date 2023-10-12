using VideoClub.Entities.Entities;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface ICatalogoRepository : IUnitOfWork
    {
        Task<Catalogo> GetById(int catalogoId);
        Task Create(Catalogo catalogo);
        Task Update(Catalogo catalogo);
        Task Delete(int catalogoId);
        Task<List<Catalogo>> GetAllCatalogos();
        Task<List<Catalogo>> GetCatalogosByCategoria(int categoriaId);
        Task<List<Catalogo>> GetCatalogosByGenero(int generoId);
    }
}
