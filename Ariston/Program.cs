using Wolverine;

IHostBuilder builder = Host.CreateDefaultBuilder(args)
    .UseWolverine((context, options) =>
    {
        
    });

IHost app = builder.Build();

app.Run();