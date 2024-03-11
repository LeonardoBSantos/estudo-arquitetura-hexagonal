using Application.services;

var service = new Service();
var sum = service.SumInts();
Console.WriteLine($"Esta é a soma de {service.entity1.IntA} com {service.entity2.IntB} = {sum.ToString()}");