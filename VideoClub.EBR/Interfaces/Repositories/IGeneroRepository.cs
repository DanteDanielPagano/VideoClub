using VideoClub.Entities.Entities;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface IGeneroRepository : IUnitOfWork
    {
        Task<Genero> GetById(int generoId);
        Task Create(Genero genero);
        Task Update(Genero genero);
        Task Delete(int generoId);
        Task<List<Genero>> GetAllGeneros();
    }
}
