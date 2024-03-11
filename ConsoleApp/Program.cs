using Application.services;
using Domain.entities.IServices;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IService, Service>()
            .BuildServiceProvider();

var service = serviceProvider.GetService<IService>();

var sum = service.SumInts();
Console.WriteLine($"Esta é a soma de dois inteiros = {sum.ToString()}");