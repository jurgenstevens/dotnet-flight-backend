using DotNetFlights.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<FlightDto> flights = [
  new (1, "United", "ORD", 1234, new DateOnly(2025, 6, 21)),
  new (2, "Southwest", "AUS", 4321, new DateOnly(2024, 8, 25)),
  new (3, "American", "LAX", 2468, new DateOnly(2025, 7, 24)),
];

// include landing route http://localhost:5157/
 

// GET http://localhost:5157/flights
app.MapGet("flights", () => flights);

// GET http://localhost:5157/flights/flightId
app.MapGet("flights/{flightId}", (int flightId) => flights.Find(flight => flight.Id == flightId));


app.Run();
