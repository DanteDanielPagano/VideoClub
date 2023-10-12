namespace VideoClub_Presenters.ActorPresenters
{
    public class CreateActorPresenter : ICreateActorPresenter
    {
        public WrapperCreateDeleteActor Actor { get; private set; } = new WrapperCreateDeleteActor();

        public Task Handle(WrapperCreateDeleteActor actor)
        {
            Actor.ErrorNumber = actor.ErrorNumber;
            Actor.ValidationErrors = actor.ValidationErrors;
            Actor.Message = actor.Message;
            Actor.IdActor = actor.IdActor;
            return Task.CompletedTask;
        }
    }
}
