// See https://aka.ms/new-console-template for more information
//https://youtu.be/y4BNWvdgccs?si=Uf9ND9tIzG1oe2ns

using ConsoleAppWithDependancyInjection.services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(
    services => {
        services.AddSingleton<IApplication, Application>();
    }).Build();

var app = host.Services.GetRequiredService<IApplication>();

app.Run();


