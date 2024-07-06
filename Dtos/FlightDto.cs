namespace DotNetFlights.Api.Dtos;

public record class FlightDto(
  int Id, 
  string Airline, 
  string Airport, 
  int FlightNo, 
  DateOnly Departs
  // List Tickets Dto
  // List Meals Dto
); 