using Notifications.Module.Application.Repositories;
using Notifications.Module.Application.Services;
using Notifications.Module.Domain;

namespace Notifications.Module.Infrastructure.Services;

public class NotificationService: INotificationService
{
    private readonly INotificationRepository _notificationRepository;
    
    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }
    
    public Task<NotificationResponse> SendNotification(CancellationToken cancellationToken)
    {
        var result = this._notificationRepository.GetNotificationData(cancellationToken);
        return result;
    }
}