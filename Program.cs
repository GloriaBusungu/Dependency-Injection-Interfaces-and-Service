// See https://aka.ms/new-console-template for more information
using ExamplesDotNetCore.DependencyInjection;
using ExamplesDotNetCore.Interfaces;
using ExamplesDotNetCore.Repositories;
using ExamplesDotNetCore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

CreateHostBuilder(args).Build();
static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostingContext, services) =>
            {
                services.AddApplication();
                services.BuildServiceProvider().GetRequiredService<PersonServices>().TestMyServiceMessage();
            });
// Wait for user input to exit
Console.ReadLine();