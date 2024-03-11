using Application.services;
using Domain.entities.IServices;

var builder = WebApplication.CreateBuilder(args);

var serviceProvider = new ServiceCollection()
            .AddSingleton<IService, Service>()
            .BuildServiceProvider();

var service = serviceProvider.GetService<IService>();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/sumInts", () =>
{
    var sum = service.SumInts();

    return sum;
});

app.Run();