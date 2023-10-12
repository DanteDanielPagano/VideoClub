using VideoClub.BusinessRules.DTOs.ActorDTOs;
using VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers;

namespace VideoClub.WebApi.EndPoint.Actor
{
    public static class VideoClubCreateActorEndPoint
    {
        public static WebApplication CreateActorEndPoint(this WebApplication app)
        {
            app.MapPost("/create", async (CreateActorRequest request, ICreateActorController controller) =>
            {
                var result = await controller.CreateActor(request);

                if (!string.IsNullOrEmpty(result.Message) || result.ValidationErrors != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }

            });

            return app;
        }
    }
}
