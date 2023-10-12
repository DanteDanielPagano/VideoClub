using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.BusinessRules.Interfaces.Presenters.ActorPresenters;
using VideoClub.BusinessRules.PersonalException;
using VideoClub.BusinessRules.Wrappers.Actor;
using VideoClub.Entities.Interfaces.Repositories;
using static VideoClub.BusinessRules.Wrappers.Actor.WrapperSelectAllActors;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    public class GetAllActorsIterator : IGetAllActorsInputPort
    {
        private readonly IActorRepository _repository;
        private readonly IGetAllActorsPresenter _presenter;

        public GetAllActorsIterator(IActorRepository repository, IGetAllActorsPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            WrapperSelectAllActors actorsResponse = new();
            try
            {
                var existingActors = await _repository.GetAllActors();

                if (existingActors != null && existingActors.Count > 0)
                {
                    foreach (var actor in existingActors)
                    {
                        actorsResponse.Actors.Add(new Actor
                        {
                            IdActor = actor.Id,
                            NombreActor = actor.NombreActor
                        });
                    }
                }
                else
                {
                    actorsResponse.ErrorNumber = 404;
                    actorsResponse.Message = "No existen registros en la tabla Actores.";
                }

            }
            catch (DBMySqlException ex)
            {
                actorsResponse.ErrorNumber = ex.Number;
                actorsResponse.Message = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(actorsResponse);
            }
        }
    }
}
