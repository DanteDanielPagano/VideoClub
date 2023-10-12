using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de insertar 
    /// un nuevo registro de un actor en el contexto.
    /// </summary>
    public interface ICreateActorPresenter : ICreateActorOutputPort
    {
        /// <summary>
        /// Expone una propiedad Actor que contiene detalles sobre la operación
        /// de inserción.
        /// </summary>
        WrapperCreateDeleteActor Actor { get; }
    }
}
