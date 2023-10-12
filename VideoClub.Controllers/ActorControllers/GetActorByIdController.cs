namespace VideoClub.Controllers.ActorControllers
{
    public class GetActorByIdController : IGetActorByIdController
    {
        readonly IGetActorByIdInputPort _inputPort;
        readonly IGetActorByIdPresenter _presenter;

        public GetActorByIdController(IGetActorByIdInputPort inputPort, IGetActorByIdPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        async Task<WrapperSelectActor> IGetActorByIdController.GetActor(int IdActor)
        {
            await _inputPort.Handle(IdActor);
            return _presenter.Actor;
        }
    }
}