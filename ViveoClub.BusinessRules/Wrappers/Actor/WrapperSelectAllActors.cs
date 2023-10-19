using VideoClub.BusinessRules.DTOs.ActorDTOs;

namespace VideoClub.BusinessRules.Wrappers.Actor
{

    public class WrapperSelectAllActors : BaseWrappers
    {
        public List<ActorResponse>? Actors { get; set; } = new List<ActorResponse>();

    }
}


