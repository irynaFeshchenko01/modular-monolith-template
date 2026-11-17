using Notifications.Module.Domain;

namespace Notifications.Module.Application.Services;

public interface INotificationService
{
    Task<NotificationResponse> SendNotification(CancellationToken cancellationToken);
}