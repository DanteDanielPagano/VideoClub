using VideoClub.BusinessRules.DTOs.ValidationDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class WrapperUpdateActor : BaseWrappers
    {
        public int IdActor { get; set; }
        public string NombreActor { get; set; }
        public List<ValidationErrorDTO>? ValidationErrors { get; set; }
    }
}
