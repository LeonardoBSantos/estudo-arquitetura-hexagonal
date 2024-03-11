using Application.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/sumInts", () =>
{
    var service = new Service();
    var sum = service.SumInts();

    return sum;
});

app.Run();