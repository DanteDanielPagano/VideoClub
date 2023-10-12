using Microsoft.Extensions.DependencyInjection;
using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.InputPorts;
using VideoClub.UseCases.UseCases.ActorUseCase;

namespace VideoClub.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateActorInputPort, CreateActorIteractor>();

            services.AddScoped<IDeleteActorInputPort, DeleteActorInteractor>();

            services.AddScoped<IUpdateActorInputPort, UpdateActorInteractor>();

            services.AddScoped<IGetActorByIdInputPort, GetActorByIdInteractor>();

            services.AddScoped<IGetAllActorsInputPort, GetAllActorsIterator>();

            return services;

        }
    }
}
