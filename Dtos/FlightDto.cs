namespace DotNetFlights.Api.Dtos;
using System.ComponentModel.DataAnnotations;

public record class FlightDto(
  int FlightId, 
  [Required][StringLength(50)] string Airline,
  [Required][StringLength(4)] string Airport, 
  [Range(1,4)] int FlightNo, 
  DateOnly Departs,
  int TicketId, // will later be a Ticket class/Dto List
  int MealId // will later be a Meals class/Dto List
); 