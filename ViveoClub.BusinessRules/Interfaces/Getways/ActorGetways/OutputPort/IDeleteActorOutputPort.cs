using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort
{
    /// <summary>
    /// Este Output Port se encarga de manejar la respuesta o salida después de eliminar un actor.
    /// </summary>
    public interface IDeleteActorOutputPort
    {
        /// <summary>
        /// Maneja la respuesta que se le envía al Presenter con los detalles de la operación
        /// de Eliminación de un Actor en el contexto.
        /// </summary>
        /// <param name="idActor">Recibir el Id del actor que se eliminó</param>
        Task Handle(WrapperDeleteActor actor);
    }

}
