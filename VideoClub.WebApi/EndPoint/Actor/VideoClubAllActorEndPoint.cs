using VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers;

namespace VideoClub.WebApi.EndPoint.Actor
{
    public static class VideoClubAllActorEndPoint
    {
        public static WebApplication GetAllActorEndPoint(this WebApplication app)
        {
            app.MapGet("/actor", async (IGetAllActorController controller) =>
            {
                var actors = await controller.GetActors();

                if (actors == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (actors.ErrorNumber != 0 && !string.IsNullOrEmpty(actors.Message))
                {
                    return Results.BadRequest(actors);
                }
                {
                    return Results.Ok(actors);
                }
            });

            return app;
        }
    }
}
