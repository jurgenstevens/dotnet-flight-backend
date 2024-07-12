using DotNetFlights.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetFlightEndpointName = "GetFlight";

List<FlightDto> flights = [
  new (1, "United", "ORD", 1234, new DateOnly(2025, 6, 21), "A2", "Carbonara"),
  new (2, "Southwest", "AUS", 4321, new DateOnly(2024, 8, 25), "B8", "Cacio e Pepe"),
  new (3, "American", "LAX", 2468, new DateOnly(2025, 7, 24), "Z3", "Amatriciana"),
];

// include landing route http://localhost:5157/
 

// GET http://localhost:5157/flights
app.MapGet("flights", () => flights);

// GET http://localhost:5157/flights/flightId
app.MapGet("flights/{flightId}", (int flightId) => flights.Find(flight => flight.FlightId == flightId)).WithName(GetFlightEndpointName);

// POST http://localhost:5157/flights
app.MapPost("flights", (CreateFlightDto newFlight) => 
{
  FlightDto flight = new(
    flights.Count + 1,
    newFlight.Airline,
    newFlight.Airport,
    newFlight.FlightNo,
    newFlight.Departs,
    newFlight.Ticket,
    newFlight.Meals
  );

  flights.Add(flight);

  return Results.CreatedAtRoute(GetFlightEndpointName, new { flightId = flight.FlightId}, flight);
});

// PUT http://localhost:5157/flights/flightId
app.MapPut("flights/{flightId}", (int flightId, UpdateFlightDto updatedFlight) => 
{
  var index = flights.FindIndex(flight => flight.FlightId == flightId);

  flights[index] = new FlightDto(
    flightId,
    updatedFlight.Airline,
    updatedFlight.Airport,
    updatedFlight.FlightNo,
    updatedFlight.Departs,
    updatedFlight.Ticket,
    updatedFlight.Meals
  );
  return Results.NoContent();
});

app.Run();
