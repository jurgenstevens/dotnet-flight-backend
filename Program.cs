using DotNetFlights.Api.Dtos;
using DotNetFlights.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
DotNetEnv.Env.Load();

app.MapFlightsEndpoints();

app.Run();