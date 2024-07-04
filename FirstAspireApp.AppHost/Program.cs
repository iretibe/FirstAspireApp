var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.FirstAspireApp_ApiService>("apiservice");

builder.AddProject<Projects.FirstAspireApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
