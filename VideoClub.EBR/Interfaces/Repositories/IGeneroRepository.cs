using VideoClub.Entities.Entities;
using VideoClub.Etities.Interfaces.Repositories;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface IGeneroRepository : IRepositoroGenerico<Genero>
    {
        Task<Genero> GetById(int generoId);

        Task<List<Genero>> GetAllGeneros();
    }
}
