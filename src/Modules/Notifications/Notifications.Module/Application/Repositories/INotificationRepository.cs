using Notifications.Module.Domain;

namespace Notifications.Module.Application.Repositories;

public interface INotificationRepository
{
    Task<NotificationResponse> GetNotificationData(CancellationToken cancellationToken = default);
}