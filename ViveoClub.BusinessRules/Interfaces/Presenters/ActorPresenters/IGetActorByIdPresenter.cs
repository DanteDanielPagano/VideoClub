using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters
{
    /// <summary>
    /// Este presenter se utiliza para manejar la presentación después de recuperar la
    /// información de un actor específico por su Id.
    /// </summary>
    public interface IGetActorByIdPresenter : IGetActorByIdOutputPort
    {
        /// <summary>
        ///  Propiedad Actor que contiene los detalles del actor recuperado.
        /// </summary>
        WrapperSelectActor Actor { get; }
    }

}
