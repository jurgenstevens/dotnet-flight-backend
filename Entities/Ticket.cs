using DotNetFlights.Api.Entities;

namespace DotNetFlights.Api;

public class Ticket
{
  public string TicketId { get; set;}
  public required string Seat { get; set;}
  public required decimal Price { get; set;}
  public int FlightId { get; set;}
  public Flight Flight { get; set;} = null!;
}
