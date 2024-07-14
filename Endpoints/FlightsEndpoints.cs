using DotNetFlights.Api.Dtos;

namespace DotNetFlights.Api.Endpoints;

public static class FlightsEndpoints
{
  private static readonly List<FlightDto> flights = [
    new (1, "United", "ORD", 1234, new DateOnly(2025, 6, 21), "A2", "Carbonara"),
    new (2, "Southwest", "AUS", 4321, new DateOnly(2024, 8, 25), "B8", "Cacio e Pepe"),
    new (3, "American", "LAX", 2468, new DateOnly(2025, 7, 24), "Z3", "Amatriciana"),
  ];

  public static WebApplication MapFlightsEndpoints(this WebApplication app)
  {
    var group = app.MapGroup("flights").WithParameterValidation();
    string GetFlightEndpointName = "GetFlight";
    // GET http://localhost:5157/flights
    app.MapGet("flights", () => flights);

    // GET http://localhost:5157/flights/flightId
    app.MapGet("flights/{flightId}", (int flightId) => 
    {
      FlightDto? flight = flights.Find(flight => flight.FlightId == flightId);

      return flight is null ? Results.NotFound() : Results.Ok(flight);
    }).WithName(GetFlightEndpointName);

    // POST http://localhost:5157/flights
    app.MapPost("flights", (CreateFlightDto newFlight) => 
    {
      if(string.IsNullOrEmpty(newFlight.Airline))
      {
        return Results.BadRequest("Airline is required.");
      }
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
    })
    .WithParameterValidation(); // Ensures parameters meet specified validation criteria

    // PUT http://localhost:5157/flights/flightId
    app.MapPut("flights/{flightId}", (int flightId, UpdateFlightDto updatedFlight) => 
    {
      var index = flights.FindIndex(flight => flight.FlightId == flightId);

      if (index == -1)
      {
        return Results.NotFound();
      }

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

    // DELETE http://localhost:5157/flights/flightId

    app.MapDelete("flights/{flightId}", (int flightId) => 
    {
      flights.RemoveAll(flight => flight.FlightId == flightId);
      return Results.NoContent();
    });

    return app;
  }
}
