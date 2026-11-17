using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var tasksApi = builder.AddProject<Projects.Notifications_Api>("notification-api");

builder.Build().Run();