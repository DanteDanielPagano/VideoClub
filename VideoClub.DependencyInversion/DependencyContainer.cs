using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VideoClub.Controllers;
using VideoClub.Presenters;
using VideoClub.Repository;
using VideoClub.UseCases;

namespace VideoClub.DependencyInversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddVideoClubServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;
        }
    }
}
