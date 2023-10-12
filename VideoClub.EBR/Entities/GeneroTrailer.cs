namespace VideoClub.Entities.Entities
{
    public class GeneroTrailer
    {
        public int IdCatalogo { get; set; } // Clave primaria y clave foránea a 'catalogo'.
        public int IdGenero { get; set; } // Clave primaria y clave foránea a 'generos'.

        // Propiedades de navegación hacia las entidades relacionadas.
        public Catalogo Catalogo { get; set; }
        public Genero Genero { get; set; }
    }

}
