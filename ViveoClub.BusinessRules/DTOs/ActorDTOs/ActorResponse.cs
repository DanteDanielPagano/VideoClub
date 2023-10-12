namespace VideoClub.BusinessRules.DTOs.ActorDTOs
{
    /// <summary>
    /// DTO que representa la información de un actor que se envía como respuesta 
    /// desde la capa de negocio al controlador o presentación.
    /// </summary>
    public class ActorResponse
    {
        public int IdActor { get; set; }
        public string? NombreActor { get; set; }
    }
}
