using DotNetFlights.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<FlightDto> flights = [
  new (1, "United", "ORD", 1234, new DateOnly(2025, 6, 21)),
  new (2, "Southwest", "AUS", 4321, new DateOnly(2024, 8, 25)),
  new (3, "American", "LAX", 2468, new DateOnly(2025, 7, 24)),
];

// app.MapGet("/", () => "Hello World!");
app.MapGet("flights", () => flights);

app.Run();
