using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort
{
    /// <summary>
    /// Este Output Port se utilizaría para manejar la respuesta o salida después
    /// de recuperar la información de un actor específico.
    /// </summary>
    public interface IGetActorByIdOutputPort
    {
        /// <summary>
        /// Maneja la respuesta que se le envía al Presenter con los detalles de un Actor
        /// específico según su Id.
        /// </summary>
        /// <param name="actor">Contiene los detalles del actor recuperado.</param>
        Task Handle(WrapperSelectActor actor);
    }

}
