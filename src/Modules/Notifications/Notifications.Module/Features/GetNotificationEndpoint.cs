using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Routing;
using Notifications.Module.Domain;

namespace Notifications.Module.Features;

internal static class GetTaskEndpoint
{
    public static void MapGetTask(this RouteGroupBuilder group)
    {
        group.MapGet("", Handle)
            .WithName("GetNotification")
            .WithSummary("Get notification test");
    }
    private static async Task<Results<Ok<NotificationResponse>, NotFound>> Handle(
        GetNotificationHandler handler,
        CancellationToken ct)
    {
        var notification = await handler.Handle(ct);

        return notification is not null
            ? TypedResults.Ok(notification)
            : TypedResults.NotFound();
    }
}