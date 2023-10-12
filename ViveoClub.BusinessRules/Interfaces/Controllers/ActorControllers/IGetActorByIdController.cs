using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface IGetActorByIdController
    {
        Task<WrapperSelectActor> GetActor(int IdActor);
    }
}
