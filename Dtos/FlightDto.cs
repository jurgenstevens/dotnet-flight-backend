namespace DotNetFlights.Api.Dtos;

public record class FlightDto(
  int Id, 
  string Airline, 
  string Airport, 
  int FlightNo, 
  DateOnly Departs,
  string Ticket, // will later be a Ticket class/Dto List
  string Meals // will later be a Meals class/Dto List
); 