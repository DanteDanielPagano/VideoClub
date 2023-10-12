using VideoClub.Entities.Interfaces.Repositories;
using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.Wrappers.Actor;

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

            WrapperCreateDeleteActor actorResponse = new();
            try
            {
                // Obtener el actorResponse existente por su ID
                var existingActor = _repository.GetById(idActor);

                if (existingActor == null)
                {
                    // Manejar el caso en el que el actorResponse no existe
                    // Devuelve un mensaje indicando que el actorResponse no se encontró.
                    actorResponse.ErrorNumber = 404;
                    actorResponse.Message = "El Id proporcionado no es valido o no existe";
                    await _presenter.Handle(actorResponse);
                    return;
                }

                // Eliminar el actor
                await _repository.Delete(idActor);
                await _repository.SaveChange();
                actorResponse.IdActor = idActor;
            }
            catch (Exception ex)
            {
                // Manejar errores
                actorResponse.Message = ex.Message;
            }
            finally
            {
                // Notificar al presentador que se eliminó el actor.
                await _presenter.Handle(actorResponse);
            }

        }
    }
}
