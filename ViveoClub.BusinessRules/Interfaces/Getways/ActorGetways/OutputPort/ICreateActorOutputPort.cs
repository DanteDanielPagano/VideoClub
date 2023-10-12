using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort
{
    /// Este Output Port se utiliza para manejar la respuesta o salida después
    /// de insertar la información de un actor.
    public interface ICreateActorOutputPort
    {
        /// <summary>
        /// Manejala respuesta que se le envia al Presenter con los detalles de la operación
        /// de inserción de un Actor en el contexto.
        /// </summary>
        /// <param name="actor">Recibe un objeto WrapperCreateDeleteActor que contiene detalles sobre la operación.</param>
        Task Handle(WrapperCreateDeleteActor actor);
    }
}
