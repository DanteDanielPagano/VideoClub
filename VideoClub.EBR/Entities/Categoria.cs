using VideoClub.Entities.Common;

namespace VideoClub.Entities.Entities
{
    public class Categoria : EntityCommon
    {
        public string NombreCategoria { get; set; }
        public ICollection<Catalogo> Catalogos { get; set; }
    }

}
