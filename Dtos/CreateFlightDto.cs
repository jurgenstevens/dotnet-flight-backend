namespace DotNetFlights.Api.Dtos;

public record class CreateFlightDto(
  string Airline,
  string Airport, 
  int FlightNo, 
  DateOnly Departs
)
