using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.PersonalException;
using VideoClub.BusinessRules.Wrappers.Actor;
using VideoClub.Entities.Interfaces.Repositories;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    public class DeleteActorInteractor : IDeleteActorInputPort
    {
        private readonly IActorRepository _repository;
        private readonly IDeleteActorPresenter _presenter;

        public DeleteActorInteractor(IActorRepository repository, IDeleteActorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idActor)
        {

            WrapperDeleteActor actorResponse = new();
            try
            {
                // Eliminar el actor
                await _repository.Delete(idActor);
                await _repository.SaveChange();
                actorResponse.IdActor = idActor;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                actorResponse.ErrorNumber = ex.Number;
                actorResponse.Message = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el actor.
                await _presenter.Handle(actorResponse);
            }

        }
    }
}
