namespace VideoClub.Presenters.ActorPresenters
{
    public class GetAllActorPresenter : IGetAllActorsPresenter
    {
        public WrapperSelectAllActors Actors { get; private set; }

        public ValueTask Handle(WrapperSelectAllActors actors)
        {
            //foreach (var actor in actors)
            //{
            //    Actors.Append(new WrapperSelectActor
            //    {
            //        IdActor = actor.IdActor,
            //        NombreActor = actor.NombreActor,
            //        ErrorNumber = actor.ErrorNumber,
            //        Message = string.IsNullOrEmpty(actor.Message) ? "" : actor.Message

            //    });
            //}
            Actors = actors;
            return ValueTask.CompletedTask;
        }
    }
}
