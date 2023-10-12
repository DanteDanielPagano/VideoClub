using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de recuperar una 
    /// lista de todos los actores disponibles en el contexto. 
    /// </summary>
    public interface IGetAllActorsPresenter : IGetAllActorsOutputPort
    {
        /// <summary>
        /// Propiedad Actors que contiene la colección de objetos ActorResponse
        /// que representan a todos los actores.
        /// </summary>
        WrapperSelectAllActors Actors { get; }
    }

}
