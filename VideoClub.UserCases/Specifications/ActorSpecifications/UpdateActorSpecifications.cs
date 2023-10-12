using VideoClub.BusinessRules.DTOs.ActorDTOs;
using VideoClub.BusinessRules.DTOs.ValidationDTO;
using VideoClub.BusinessRules.Interfaces.ValidationSpecification;

namespace VideoClub.UseCases.Specifications.ActorSpecifications
{
    public class UpdateActorSpecifications : ISpecification<UpdateActorRequest>
    {
        readonly UpdateActorRequest _entity;
        readonly List<ValidationErrorDTO> _errors = new List<ValidationErrorDTO>();

        public UpdateActorSpecifications(UpdateActorRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDTO> IsValid()
        {
            if (_entity.IdActor == 0)
            {
                _errors.Add(new ValidationErrorDTO()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especficar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.NombreActor))
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.NombreActor) && _entity.NombreActor.Length > 45)
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
