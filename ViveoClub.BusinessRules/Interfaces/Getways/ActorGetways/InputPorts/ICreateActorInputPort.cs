using VideoClub.BusinessRules.DTOs.ActorDTOs;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de un nuevo actor en el sistema. 
    /// </summary>
    public interface ICreateActorInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateActorRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="creatActorRequest">Contiene los detalles del nuevo actor a crear.</param>
        Task Handle(CreateActorRequest creatActorRequest);
    }
}
