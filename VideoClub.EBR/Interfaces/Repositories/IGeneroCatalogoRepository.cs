namespace VideoClub.Entities.Interfaces.Repositories
{
    public interface IGeneroCatalogoRepository
    {
        Task AddGeneroToCatalogo(int catalogoId, int generoId);
        Task RemoveGeneroFromCatalogo(int catalogoId, int generoId);
    }
}
