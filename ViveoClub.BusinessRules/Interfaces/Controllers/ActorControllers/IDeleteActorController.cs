using VideoClub.BusinessRules.DTOs.ActorDTOs;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface IDeleteActorController
    {
        Task<ActorResponse> DeletetActor(int IdActor);
    }
}
