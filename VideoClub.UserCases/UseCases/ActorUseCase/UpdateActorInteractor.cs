using VideoClub.Entities.Entities;
using VideoClub.Entities.Interfaces.Repositories;
using VideoClub.UseCases.Specifications.ActorSpecifications;
using VideoClub.BusinessRules.DTOs.ActorDTOs;
using VideoClub.BusinessRules.DTOs.ValidationDTO;
using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    public class UpdateActorInteractor : IUpdateActorInputPort
    {
        private readonly IActorRepository _repository;
        private readonly IUpdateActorPresenter _presenter;

        public UpdateActorInteractor(IActorRepository repository, IUpdateActorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(UpdateActorRequest updateActorRequest)
        {
            List<ValidationErrorDTO> errors = new List<ValidationErrorDTO>();
            WrapperUpdateActor actorResponse = new();

            try
            {
                //Valida los datos del actorResponse a actualizar.
                errors = ValidateActor(updateActorRequest);

                if (errors.Any())
                {
                    // Manejar el caso en el que el actorResponse no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del actorResponse no son validos.
                    actorResponse.ValidationErrors = errors;
                    await _presenter.Handle(actorResponse);
                    return;
                }

                // Obtener el actorResponse existente por su ID
                Actor existingActor = await _repository.GetById(updateActorRequest.IdActor);
                if (existingActor == null)
                {
                    // Manejar el caso en el que el actorResponse no existe
                    // Devuelve un mensaje indicando que el actorResponse no se encontró.
                    actorResponse.ErrorNumber = 404;
                    actorResponse.Message = $"El acton con {updateActorRequest.IdActor} no existe";
                    await _presenter.Handle(actorResponse);
                    return;
                }

                // Actualizar la información del actorResponse con los datos proporcionados
                existingActor.NombreActor = updateActorRequest.NombreActor;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingActor);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                actorResponse.IdActor = existingActor.Id;
                actorResponse.NombreActor = existingActor.NombreActor;

                // Enviar la respuesta al presentador
                await _presenter.Handle(actorResponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                actorResponse.Message = ex.Message;
            }
            finally
            {
                await _presenter.Handle(actorResponse);
            }
        }

        private List<ValidationErrorDTO> ValidateActor(UpdateActorRequest updateActorRequest)
        {
            var specification = new UpdateActorSpecifications(updateActorRequest);
            return specification.IsValid();
        }
    }
}
