namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la eliminación de un actor.
    /// </summary>
    public interface IDeleteActorInputPort
    {
        /// <summary>
        /// El método Handle elimina un actor del contexto en base a su Id.
        /// </summary>
        /// <param name="idActor">Id del actor que se debe eliminar.</param>
        /// <returns></returns>
        Task Handle(int idActor);
    }

}
