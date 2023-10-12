using VideoClub.Entities.Common;

namespace VideoClub.Entities.Entities
{
    public class Catalogo : EntityCommon
    {
        public string Poster { get; set; }
        public string Titulo { get; set; }
        public int IdCategoria { get; set; }
        public string Resumen { get; set; }
        public int? Temporadas { get; set; }
        public string EnlaceTrailer { get; set; }

        public Categoria Categoria { get; set; }
        public ICollection<GeneroTrailer> GeneroTrailers { get; set; }
        public ICollection<Reparto> Repartos { get; set; }
    }

}
