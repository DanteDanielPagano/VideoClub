namespace VideoClub.Entities.Entities
{
    public class Reparto
    {
        public int IdTrailer { get; set; }
        public int IdActor { get; set; }
        public Catalogo Catalogo { get; set; }
        public Actor Actor { get; set; }
    }

}
