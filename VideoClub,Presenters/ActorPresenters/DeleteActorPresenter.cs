namespace VideoClub_Presenters.ActorPresenters
{
    public class DeleteActorPresenter : IDeleteActorPresenter
    {
        public WrapperDeleteActor Actor { get; private set; } = new WrapperDeleteActor();

        public Task Handle(WrapperDeleteActor actor)
        {
            Actor.ErrorNumber = actor.ErrorNumber;
            Actor.Message = actor.Message;
            Actor.IdActor = actor.IdActor;
            return Task.CompletedTask;
        }
    }
}
