namespace DotNetFlights.Api.Dtos;

public record class FlightDto(
  int Id, 
  string Airline, 
  string Airport, 
  int FlightNo, 
  DateTime Departs
  ); 