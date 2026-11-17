using Notifications.Module.Application.Repositories;
using Notifications.Module.Domain;

namespace Notifications.Module.Infrastructure.Repositories;

public class NotificationRepository: INotificationRepository
{
    public Task<NotificationResponse> GetNotificationData(CancellationToken cancellationToken = default)
    {
        var response = new NotificationResponse
        {
            Title = "Reminder",
            Message = "Start task immediately"
        };

        return Task.FromResult(response);
    }
}