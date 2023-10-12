namespace VideoClub.Controllers.ActorControllers
{
    public class GetAllActorController : IGetAllActorController
    {
        readonly IGetAllActorsInputPort _inputPort;
        readonly IGetAllActorsPresenter _presenter;

        public GetAllActorController(IGetAllActorsInputPort inputPort, IGetAllActorsPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<WrapperSelectAllActors> GetActors()
        {
            await _inputPort.Handle();
            return _presenter.Actors;
        }
    }
}
