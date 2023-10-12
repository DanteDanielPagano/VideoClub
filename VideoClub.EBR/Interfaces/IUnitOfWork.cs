namespace VideoClub.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
