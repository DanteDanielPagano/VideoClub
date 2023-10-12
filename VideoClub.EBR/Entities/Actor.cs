using VideoClub.Entities.Common;

namespace VideoClub.Entities.Entities
{
    public class Actor : EntityCommon
    {
        public string NombreActor { get; set; }
        public ICollection<Reparto> Reparto { get; set; }
    }

}
