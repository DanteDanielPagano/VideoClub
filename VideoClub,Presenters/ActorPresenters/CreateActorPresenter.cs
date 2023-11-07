namespace VideoClub_Presenters.ActorPresenters
{
    public class CreateActorPresenter : ICreateActorPresenter
    {
        public WrapperCreateActor Actor { get; private set; } = new WrapperCreateActor();

        public Task Handle(WrapperCreateActor actor)
        {

            Actor.ErrorNumber = actor.ErrorNumber;
            Actor.ValidationErrors = actor.ValidationErrors;
            Actor.Message = actor.Message;
            Actor.IdActor = actor.IdActor;
            return Task.CompletedTask;
        }
    }
}
