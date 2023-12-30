using LivrariaOnline.Backend.DependencyInversion;

var builder = WebApplication.CreateBuilder(args);

builder.Services
              .AddEnvironment()
              .AddProviders(builder.Environment.IsDevelopment())
              .AddRepositories()
              .AddUseCases();

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
