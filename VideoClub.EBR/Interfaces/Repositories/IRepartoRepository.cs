namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface IRepartoRepository : IUnitOfWork
    {
        Task AddActorToCatalogo(int catalogoId, int actorId);
        Task RemoveActorFromCatalogo(int catalogoId, int actorId);
    }
}
