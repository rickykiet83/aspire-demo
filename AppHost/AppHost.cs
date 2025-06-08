var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Api>("api")
    .WithReplicas(3) // API project with 3 replicas
    .WithExplicitStart() // API project will not start automatically
    ; 

builder.AddProject<Projects.Frontend>("frontend")
    .WithReference(api) // frontend dependent the API project
    .WaitFor(api)
    .WithExternalHttpEndpoints()
    ;

builder.Build().Run();