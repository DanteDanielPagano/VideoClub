using VideoClub.BusinessRules.DTOs.ActorDTOs;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se utiliza para manejar la actualización de la información de un actor
    /// existente. 
    /// </summary>
    public interface IUpdateActorInputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto UpdateActorRequest con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="updateActorRequest">Contiene los detalles actualizados del actor,
        /// incluido el Id del actor que se debe actualizar.</param>
        Task Handle(UpdateActorRequest updateActorRequest);
    }

}
