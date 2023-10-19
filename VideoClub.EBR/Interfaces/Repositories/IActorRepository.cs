using VideoClub.Entities.Entities;

namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface IActorRepository : IUnitOfWork
    {
        Task<Actor> GetById(int actorId);
        Task Create(Actor actor);
        Task Update(Actor actor);
        Task Delete(int actorId);
        Task<List<Actor>> GetAllActors();
        //Task<List<Actor>> GetAllActorsByName(string name);
    }
}

