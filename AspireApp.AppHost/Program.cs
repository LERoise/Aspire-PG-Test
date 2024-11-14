var builder = DistributedApplication.CreateBuilder(args);


var pg = builder.AddPostgres("pgtest")
    .WithDataVolume()
    .AddDatabase("pg-db");

builder.AddProject<Projects.WebApplication1>("webapplication1");

builder.Build().Run();
