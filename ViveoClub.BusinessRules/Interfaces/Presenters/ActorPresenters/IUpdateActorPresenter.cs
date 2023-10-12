using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de actualizar la
    /// información de un actor.
    /// </summary>
    public interface IUpdateActorPresenter : IUpdateActorOutputPort
    {
        /// <summary>
        /// Expone una propiedad Actor que contiene detalles sobre la operación
        /// de actualización.
        /// </summary>
        WrapperUpdateActor Actor { get; }
    }

}
