using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.Wrappers.Actor;
using VideoClub.Entities.Interfaces.Repositories;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    public class GetActorByIdInteractor : IGetActorByIdInputPort
    {
        private readonly IActorRepository _repository;
        private readonly IGetActorByIdPresenter _presenter;

        public GetActorByIdInteractor(IActorRepository repository, IGetActorByIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int idActor)
        {
            WrapperSelectActor actorResponse = new();

            try
            {
                var existingActor = await _repository.GetById(idActor);
                if (existingActor != null)
                {
                    actorResponse.IdActor = existingActor.Id;
                    actorResponse.NombreActor = existingActor.NombreActor;
                }
                else
                {
                    actorResponse.ErrorNumber = 404;
                    actorResponse.Message = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                actorResponse.Message = ex.Message;

            }
            finally
            {
                await _presenter.Handle(actorResponse);
            }
        }
    }
}
