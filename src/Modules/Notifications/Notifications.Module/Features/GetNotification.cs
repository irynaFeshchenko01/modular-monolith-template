using Notifications.Module.Application.Services;
using Notifications.Module.Domain;

namespace Notifications.Module.Features;

internal sealed class GetNotificationHandler(INotificationService service)
{
    public Task<NotificationResponse> Handle(CancellationToken ct)
    {
        return service.SendNotification(ct);
    }
}