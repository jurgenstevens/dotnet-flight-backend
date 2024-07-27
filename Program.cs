using DotNetFlights.Api.Data;
using DotNetFlights.Api.Endpoints;
using DotNetFlights.Api.Entities;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);
builder.AddSqlServerDbContext<DotNetFlightsContext>("sqldata");
var connString = builder.Configuration.GetConnectionString("DotNetFlightsContext");

var app = builder.Build();

app.MapFlightsEndpoints();

app.Run();
