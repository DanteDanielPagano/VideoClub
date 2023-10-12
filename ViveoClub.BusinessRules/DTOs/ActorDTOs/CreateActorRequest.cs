namespace VideoClub.BusinessRules.DTOs.ActorDTOs
{
    /// <summary>
    ///  DTO que se utiliza para transferir datos de entrada cuando se está creando un nuevo
    ///  actor en la capa de controlador o presentación y se necesita enviar esos datos a la
    ///  capa de negocio.
    /// </summary>
    public class CreateActorRequest
    {
        public string? NombreActor { get; set; }
    }
}
