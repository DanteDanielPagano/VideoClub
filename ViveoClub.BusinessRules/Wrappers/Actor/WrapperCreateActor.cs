using VideoClub.BusinessRules.DTOs.ValidationDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class WrapperCreateActor : BaseWrappers
    {
        public int IdActor { get; set; }
        public List<ValidationErrorDTO>? ValidationErrors { get; set; }
    }
}
