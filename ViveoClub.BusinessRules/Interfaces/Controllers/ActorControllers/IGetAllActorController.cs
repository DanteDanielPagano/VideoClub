using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface IGetAllActorController
    {
        ValueTask<WrapperSelectAllActors> GetActors();
    }
}
