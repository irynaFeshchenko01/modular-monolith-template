using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Notifications.Module.Features;

namespace Notifications.Module;

public static class NotificationsModuleExtensions
{
    public static IServiceCollection AddTasksModule(this IServiceCollection services)
    {
        services.AddScoped<GetNotificationHandler>();

        return services;
    }

    public static IEndpointRouteBuilder MapTasksEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/notification")
            .WithTags("Notifications");

        group.MapGetTask();

        return app;
    }
}