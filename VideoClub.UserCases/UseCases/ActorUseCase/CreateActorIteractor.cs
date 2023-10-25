
using VideoClub.BusinessRules.DTOs.ActorDTOs;
using VideoClub.BusinessRules.DTOs.ValidationDTO;
using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.PersonalException;
using VideoClub.BusinessRules.Wrappers.Actor;
using VideoClub.Entities.Entities;
using VideoClub.Entities.Interfaces.Repositories;
using VideoClub.UseCases.Specifications.ActorSpecifications;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    /// <summary>
    /// Clase que implementa el Input Port para crear un actorResponse.
    /// </summary>
    public class CreateActorIteractor : ICreateActorInputPort
    {
        readonly IActorRepository _repository;
        readonly ICreateActorPresenter _presenter;

        /// <summary>
        /// Constructor de la clase CreateActorIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de actores.</param>
        /// <param name="presenter">El presentador para la creación de actores.</param>
        public CreateActorIteractor(IActorRepository repository, ICreateActorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo actorResponse.
        /// </summary>
        /// <param name="createActorRequest">Los datos para crear el actorResponse.</param>
        /// <returns>El ID del nuevo actorResponse creado o 0 si hubo errores.</returns>
        public async Task Handle(CreateActorRequest creatActorRequest)
        {
            List<ValidationErrorDTO> errors = new List<ValidationErrorDTO>();
            errors = ValidateActor(creatActorRequest);
            WrapperCreateDeleteActor actorResponse = new();

            if (errors.Any())
            {
                actorResponse.ValidationErrors = errors;
                await _presenter.Handle(actorResponse);
                return;
            }

            Actor newActor = new()
            {
                NombreActor = creatActorRequest.NombreActor
            };

            try
            {
                await _repository.Create(newActor);
                await _repository.SaveChange();
                actorResponse.IdActor = newActor.Id;
            }
            catch (DBMySqlException ex)
            {
                actorResponse.ErrorNumber = ex.Number;
                actorResponse.Message = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(actorResponse);
            }
        }

        private List<ValidationErrorDTO> ValidateActor(CreateActorRequest creatActorRequest)
        {
            var specification = new CreateActorSpecifications(creatActorRequest);
            return specification.IsValid();
        }
    }
}
