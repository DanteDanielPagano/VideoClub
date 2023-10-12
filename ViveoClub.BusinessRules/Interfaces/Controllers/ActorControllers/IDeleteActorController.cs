using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface IDeleteActorController
    {
        Task<WrapperDeleteActor> DeletetActor(int IdActor);
    }
}
