#nullable disable
//using Microsoft.EntityFrameworkCore.sql
namespace VideoClub.Repository
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<VideoClubContext>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IActorRepository, ActorRepository>();

            return services;
        }
    }
}
