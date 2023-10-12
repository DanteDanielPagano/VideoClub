namespace VideoClub_Presenters.ActorPresenters
{
    public class GetActorByIdPresenter : IGetActorByIdPresenter
    {
        public WrapperSelectActor Actor { get; private set; }

        public Task Handle(WrapperSelectActor actor)
        {
            Actor = new WrapperSelectActor
            {
                IdActor = actor.IdActor,
                NombreActor = actor.NombreActor,
                ErrorNumber = actor.ErrorNumber,
                Message = actor.Message
            };
            return Task.CompletedTask;
        }
    }
}
