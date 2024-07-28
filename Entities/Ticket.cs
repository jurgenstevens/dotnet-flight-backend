using DotNetFlights.Api.Entities;

namespace DotNetFlights.Api;

public class Ticket
{
  public int TicketId { get; set;}
  public required string Seat { get; set;}
  public required decimal Price { get; set;}
  public int FlightId { get; set;} // Required foreign key property
  public Flight Flight { get; set;} = null!; // Required reference navigation to principal
}
