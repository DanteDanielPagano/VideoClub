using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort
{
    /// <summary>
    /// Este Output Port se encargaría de manejar la respuesta o salida después de recuperar
    /// una lista de todos los actores disponibles en el contexto.
    /// </summary>
    public interface IGetAllActorsOutputPort
    {
        /// <summary>
        /// Manejala respuesta que se le envia al Presenter con los detalles de la operación
        /// de seleccion de todos los Actores en el contexto. 
        /// </summary>
        /// <param name="actors">Contiene una lista con todos los actores de la tabla Actores del contexto.</param>
        ValueTask Handle(WrapperSelectAllActors actors);
    }

}
