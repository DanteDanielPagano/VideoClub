using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort
{
    /// <summary>
    /// Este Output Port se utiliza para manejar la respuesta o salida después
    /// de actualizar la información de un actor.
    /// </summary>
    public interface IUpdateActorOutputPort
    {
        /// <summary>
        /// Manejala respuesta que se le envia al Presenter con los detalles de la operación
        /// de actualización de una Actor en el contexto.
        /// </summary>
        /// <param name="actor">Recibe un objeto WrapperCreateActor que contiene detalles sobre la operación.</param>
        Task Handle(WrapperUpdateActor actor);
    }

}
