using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de realizar un borrado
    /// lógico de un actor desde el contexto.
    /// </summary>
    public interface IDeleteActorPresenter : IDeleteActorOutputPort
    {
        /// <summary>
        /// Propiedad Actor que contiene detalles sobre la operación
        /// de eliminación.
        /// </summary>
        WrapperCreateDeleteActor Actor { get; }
    }
}
