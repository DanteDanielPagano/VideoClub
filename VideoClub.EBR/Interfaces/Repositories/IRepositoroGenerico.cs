using VideoClub.Entities.Interfaces;

namespace VideoClub.Etities.Interfaces.Repositories
{
    public interface IRepositoroGenerico<in T> : IUnitOfWork
    {

        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int Id);

    }
}
