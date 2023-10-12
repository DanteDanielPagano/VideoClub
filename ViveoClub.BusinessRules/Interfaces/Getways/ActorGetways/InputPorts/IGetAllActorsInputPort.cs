namespace VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de recuperar una lista de todos los actores disponibles en el contexto.
    /// </summary>
    public interface IGetAllActorsInputPort
    {
        /// <summary>
        ///  El método Handle ejecuta una query en el contexto para obtener el contenido de
        ///  la tabla actores.
        /// </summary>
        /// <returns>Colección de objetos ActorResponse que representan a todos los actores.</returns>
        ValueTask Handle();
    }

}
