namespace Notifications.Module.Domain;

public sealed record NotificationResponse
{
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}