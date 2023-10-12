using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.Controllers.ActorControllers
{
    public class DeleteActorController : IDeleteActorController
    {
        readonly IDeleteActorInputPort _inputPort;
        readonly IDeleteActorPresenter _presenter;

        public DeleteActorController(IDeleteActorInputPort inputPort, IDeleteActorPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperDeleteActor> DeletetActor(int IdActor)
        {
            await _inputPort.Handle(IdActor);
            return _presenter.Actor;
        }
    }
}