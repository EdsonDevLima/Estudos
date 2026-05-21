using SystemSaudeApi.Infrastructure.Database;
using TodoApi.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDbConnectionFactory,SqlServerConnectionFactory>();
builder.Services.AddScoped<DataInitializer>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var initializer = scope.ServiceProvider.GetRequiredService<DataInitializer>();
    await initializer.InitializeAsync();
}





app.Run();
