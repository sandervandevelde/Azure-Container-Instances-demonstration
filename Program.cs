using ConsoleModule;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>services.AddHostedService<ConsoleBackgroundService>())
    .Build();

host.Run();