var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var db = builder.AddPostgres("postgres")
    .WithDataVolume() // This will create a data volume for the Postgres database
    .WithPgWeb() // Optional: Adds pgWeb for database management
    .AddDatabase("eventing-db"); // Adds a database service to the application

var apiService = builder.AddProject<Projects.EventingApp_ApiService>("apiservice")
    // .WithHttpHealthCheck("/health")
    .WaitFor(db)
    .WithReference(db);

builder.AddProject<Projects.EventingApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();