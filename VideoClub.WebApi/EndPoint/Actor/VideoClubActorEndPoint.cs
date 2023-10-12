using VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers;

namespace VideoClub.WebApi.EndPoint.Actor
{
    public static class VideoClubActorEndPoint
    {
        public static WebApplication GetActorEndPoint(this WebApplication app)
        {
            app.MapGet("/actor/{id}", async (IGetActorByIdController controller, int id) =>
            {
                var actor = await controller.GetActor(id);

                if (actor == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (actor.ErrorNumber != 0 && !string.IsNullOrEmpty(actor.Message))
                {
                    return Results.BadRequest(actor);

                }
                {
                    return Results.Ok(actor);
                }
            });

            return app;
        }
    }
}
