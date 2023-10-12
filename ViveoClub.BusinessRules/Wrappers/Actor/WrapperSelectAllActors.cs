namespace VideoClub.BusinessRules.Wrappers.Actor
{

    public class WrapperSelectAllActors : BaseWrappers
    {
        public List<Actor>? Actors { get; set; } = new List<Actor>();

        public class Actor
        {
            public int IdActor { get; set; }
            public string NombreActor { get; set; }
        }
    }
}


