using Microsoft.Extensions.DependencyInjection;
using VideoClub.BusinessRules.Interfaces.Getways.ActorGetways.OutputPort;
using VideoClub.Presenters.ActorPresenters;
using VideoClub_Presenters.ActorPresenters;

namespace VideoClub.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            services.AddScoped<GetAllActorPresenter>();

            services.AddScoped<IGetAllActorsOutputPort, GetAllActorPresenter>();

            services.AddScoped<IGetAllActorsPresenter, GetAllActorPresenter>();



            services.AddScoped<ICreateActorPresenter, CreateActorPresenter>();

            services.AddScoped<IDeleteActorPresenter, DeleteActorPresenter>();

            services.AddScoped<IGetActorByIdPresenter, GetActorByIdPresenter>();

            services.AddScoped<IUpdateActorPresenter, UpdateActorPresenter>();

            return services;
        }
    }
}
