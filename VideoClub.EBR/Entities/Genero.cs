using VideoClub.Entities.Common;

namespace VideoClub.Entities.Entities
{
    public class Genero : EntityCommon
    {
        public string NombreGenero { get; set; }
        public ICollection<GeneroTrailer> GeneroTrailers { get; set; }
    }

}
