using VideoClub.BusinessRules.DTOs.ActorDTOs;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface IUpdateActorController
    {
        Task<WrapperCreateActor> UpdateActor(UpdateActorRequest request);
    }
}
