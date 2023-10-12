
namespace VideoClub.Controllers.ActorControllers
{
    public class CreateActorController : ICreateActorController
    {
        readonly ICreateActorInputPort _inputPort;
        readonly ICreateActorPresenter _presenter;

        public CreateActorController(ICreateActorInputPort inputPort, ICreateActorPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperCreateDeleteActor> CreateActor(CreateActorRequest request)
        {
            await _inputPort.Handle(request);
            return _presenter.Actor;
        }
    }
}
