using DotNetFlights.Api.Data;
using DotNetFlights.Api.Endpoints;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DotNetFlightsContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("DotNetFlightsContext")));

var app = builder.Build();

app.MapFlightsEndpoints();

app.MigrateDb();

app.Run();
