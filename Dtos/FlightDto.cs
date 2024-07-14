namespace DotNetFlights.Api.Dtos;
using System.ComponentModel.DataAnnotations;

public record class FlightDto(
  [Required][StringLength(50)] string Airline,
  [Required][StringLength(4)] string Airport, 
  [Range(1,4)] int FlightNo,
  DateOnly Departs,
  string Ticket, // will later be a Ticket class/Dto List
  string Meals // will later be a Meals class/Dto List
); 