using DotNetFlights.Api.Dtos;
using DotNetFlights.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DotNetFlightsContext");

var app = builder.Build();

app.MapFlightsEndpoints();

app.Run();