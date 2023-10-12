namespace VideoClub.BusinessRules.DTOs.ActorDTOs
{
    /// <summary>
    /// DTO que se utiliza para transferir datos de entrada cuando se está
    /// actualizando la información de un actor existente.
    /// </summary>
    public class UpdateActorRequest
    {
        public int IdActor { get; set; }
        public string? NombreActor { get; set; }
    }
}
