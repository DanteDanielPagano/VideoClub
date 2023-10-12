using VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers;

namespace VideoClub.WebApi.EndPoint.Actor
{
    public static class VideoClubDeleteActorEndPoint
    {
        public static WebApplication DeleteActorEndPoint(this WebApplication app)
        {
            app.MapPut("/actor/delete/{id}", async (IDeleteActorController controller, int id) =>
            {
                var actor = await controller.DeletetActor(id);
                if (actor == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (actor.ErrorNumber != 0 && !string.IsNullOrEmpty(actor.Message))
                {
                    return Results.BadRequest(actor);
                }

                return Results.Ok(actor);
            });
            return app;
        }
    }
}
