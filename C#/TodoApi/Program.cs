using SystemSaudeApi.Infrastructure.Database;
using TodoApi.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

//configuração para ativar controllers
builder.Services.AddControllers();

//injeção de depandencia para configuração do banco de dados
builder.Services.AddScoped<IDbConnectionFactory,SqlServerConnectionFactory>();
builder.Services.AddScoped<DataInitializer>();


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
