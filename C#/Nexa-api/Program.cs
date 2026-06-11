using SystemSaudeApi.Infrastructure.Database;
using Nexa.Infrastructure.Database;
using Nexa.UseCases;

var builder = WebApplication.CreateBuilder(args);

//configuração para ativar controllers
builder.Services.AddControllers();

//injeção de depandencia para configuração do banco de dados
builder.Services.AddScoped<IDbConnectionFactory,SqlServerConnectionFactory>();
builder.Services.AddScoped<DataInitializer>();
//injeção dos casos de uso
builder.Services.AddScoped<UserUseCases>();
builder.Services.AddScoped<TaskUseCases>();
//configuração para documentação swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(options =>{
    
    options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
    options.RoutePrefix = string.Empty;

    
    });
    app.UseSwagger();
}

//inicialização de banco de dados com injeção de dependencia
using (var scope = app.Services.CreateScope())
{
    var initializer = scope.ServiceProvider.GetRequiredService<DataInitializer>();
    await initializer.InitializeAsync();
}

app.Run();
