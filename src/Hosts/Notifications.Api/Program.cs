using Notifications.Module;
using Notifications.Module.Application.Repositories;
using Notifications.Module.Application.Services;
using Notifications.Module.Infrastructure.Repositories;
using Notifications.Module.Infrastructure.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// builder.AddServiceDefaults();
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddTasksModule();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<INotificationService, NotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

// app.MapDefaultEndpoints(); // Health checks для Aspire
app.MapTasksEndpoints();   // Реєструємо GET /api/tasks/{id}

app.Run();